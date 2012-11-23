// Simple Player sample application
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2006-2011
// contacts@aforgenet.com
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using AForge.Imaging;

namespace Player
{
    public partial class MainForm : Form
    {
        private Stopwatch stopWatch = null;

        struct puck {
            public int location;
            public int confidence;
            public int height;
            public DateTime last_seen;
        };
        string s;
        private List<puck>[] pucks = new List<puck>[5];
        private const int THRESHOLD = 10000;

        private const int GREEN = 0;
        private const int RED = 1;
        private const int YELLOW = 2;
        private const int BLUE = 3;
        private const int ORANGE = 4;
        private const int MIN_PUCK_SIZE = 20;

        // Class constructor
        public MainForm( )
        {
            InitializeComponent( );

            // For debugging, instantly open the test file.
            FileVideoSource fileSource = new FileVideoSource(@"C:\Users\STRIDERA\Videos\ttfatf.wmv");
            OpenVideoSource(fileSource);
        }

        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            CloseCurrentVideoSource( );
        }

        // "Exit" menu item clicked
        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        // Open local video capture device
        private void localVideoCaptureDeviceToolStripMenuItem_Click( object sender, EventArgs e )
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm( );

            if ( form.ShowDialog( this ) == DialogResult.OK )
            {
                // create video source
                VideoCaptureDevice videoSource = form.VideoDevice;

                // open it
                OpenVideoSource( videoSource );
            }
        }

        // Open video file using DirectShow
        private void openVideofileusingDirectShowToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( openFileDialog.ShowDialog( ) == DialogResult.OK )
            {
                // create video source
                FileVideoSource fileSource = new FileVideoSource( openFileDialog.FileName );

                // open it
                OpenVideoSource( fileSource );
            }
        }

        // Open video source
        private void OpenVideoSource( IVideoSource source )
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseCurrentVideoSource( );

            // start new video source
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start( );

            // reset stop watch
            stopWatch = null;

            // start timer
            timer.Start( );

            this.Cursor = Cursors.Default;
        }

        // Close video source if it is running
        private void CloseCurrentVideoSource( )
        {
            if ( videoSourcePlayer.VideoSource != null )
            {
                videoSourcePlayer.SignalToStop( );

                // wait ~ 3 seconds
                for ( int i = 0; i < 30; i++ )
                {
                    if ( !videoSourcePlayer.IsRunning )
                        break;
                    System.Threading.Thread.Sleep( 100 );
                }

                if ( videoSourcePlayer.IsRunning )
                {
                    videoSourcePlayer.Stop( );
                }

                videoSourcePlayer.VideoSource = null;
            }
        }

        // New frame received by the player
        private void videoSourcePlayer_NewFrame( object sender, ref Bitmap image )
        {
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);

            try
            {
                UnmanagedImage unmanagedImg = new UnmanagedImage( imageData );

                int x = (int)(unmanagedImg.Width / 3.19); // 443
                int y = (int)(unmanagedImg.Height / 2.2); // 490
                int w = (int)(unmanagedImg.Width / 2.7); // 553
                int h = (int)(unmanagedImg.Height / 4); // 270
                int s = (int)(unmanagedImg.Width / 10.2); // 141

                // Crop the player scroll window.  Speeds up the next couple operations
                Crop onePlayer = new Crop(new Rectangle(x, y, w, h));
                UnmanagedImage img = onePlayer.Apply(unmanagedImg);

                // Use a quadrilateral transformation to make the scroller a big square.
                List<IntPoint> corners = new List<IntPoint>();
                corners.Add(new IntPoint(s, 0));
                corners.Add(new IntPoint(img.Width - s, 0)); ;
                corners.Add(new IntPoint(img.Width, img.Height));
                corners.Add(new IntPoint(0, img.Height));

                QuadrilateralTransformation filter =
                    new QuadrilateralTransformation(corners, img.Width, img.Height);
                img = filter.Apply(img);

                // Crop the bottom half since it appears to have the best imagery
                Crop bottom = new Crop(new Rectangle(0, img.Height / 2, img.Width, img.Height / 2));
                img = bottom.Apply(img);

                UnmanagedImage grayImg = UnmanagedImage.Create(img.Width, img.Height, PixelFormat.Format8bppIndexed);
                Grayscale.CommonAlgorithms.BT709.Apply(img, grayImg);

                OtsuThreshold threshold = new OtsuThreshold();
                threshold.ApplyInPlace(grayImg);

                // Divide the square into 5 peices.  One for each color.
                UnmanagedImage[] colorImg = new UnmanagedImage[5];
                for(int i=0; i < 5; i++) {
                    int colorWidth = grayImg.Width / 5;
                    int colorHeight = grayImg.Height;
                    Crop colorCrop = new Crop(new Rectangle(colorWidth * i, 0, colorWidth, colorHeight));
                    colorImg[i] = colorCrop.Apply(grayImg);
                }

                
                greenCol.Image = colorImg[GREEN].ToManagedImage();
                redCol.Image = colorImg[RED].ToManagedImage();
                yellowCol.Image = colorImg[YELLOW].ToManagedImage();
                blueCol.Image = colorImg[BLUE].ToManagedImage();
                orangeCol.Image = colorImg[ORANGE].ToManagedImage();


                VerticalIntensityStatistics[] hist = new VerticalIntensityStatistics[5];

                for (int i = 0; i < 5; i++)
                {
                    hist[i] = new VerticalIntensityStatistics(colorImg[i]);
                }

                findPucks(hist);
                
                greenHist.Values = hist[GREEN].Gray.Values;
                redHist.Values = hist[RED].Gray.Values;
                yellowHist.Values = hist[YELLOW].Gray.Values;
                blueHist.Values = hist[BLUE].Gray.Values;
                orangeHist.Values = hist[ORANGE].Gray.Values;
                
                pictureBox1.Image = img.ToManagedImage();
            }
            finally
            {
                image.UnlockBits( imageData );
            }
        }

        private void findPucks(VerticalIntensityStatistics[] hist)
        {
            // Find all the pucks
            /* Thinking for this:
             *  - Choose your color and figure out how many pucks we've found
             *    - Scan through all the lines and find all objects larger than the min puck height
             *    - Compare each item
             */

            for (int i = 0; i < 5; i++)
            {
                List<puck> found_pucks = new List<puck>();
                int cur_line = hist[i].Gray.Values.Length - 1;
                int puck_start = -1;

                while (cur_line > 0)
                {
                    if (hist[i].Gray.Values[cur_line] > THRESHOLD)
                    {
                        if (puck_start < 0)
                        {
                            puck_start = cur_line;
                        }
                    }
                    else
                    {
                        if (puck_start > 0)
                        {
                            if (cur_line == 0 || hist[i].Gray.Values[cur_line - 1] < THRESHOLD)
                            {
                                int height = puck_start - cur_line;
                                if (height > MIN_PUCK_SIZE)
                                {
                                    puck p = new puck();
                                    p.location = puck_start;
                                    p.height = height;
                                    found_pucks.Add(p);
                                }
                                puck_start = -1;
                            }
                        }
                    }
                    cur_line--;
                }
            
                if (i == 0) {
                    s += "Found " + found_pucks.Count + " Pucks: ";
                    foreach (puck p in found_pucks)
                    {
                        s += "(" + p.location + "/" + p.height + ") ";
                    }
                    s += "\r\n";
                }
            }
        }


        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
            }

            return array;
        }

        // On timer event - gather statistics
        private void timer_Tick( object sender, EventArgs e )
        {
            IVideoSource videoSource = videoSourcePlayer.VideoSource;

            if ( videoSource != null )
            {
                // get number of frames since the last timer tick
                int framesReceived = videoSource.FramesReceived;

                if ( stopWatch == null )
                {
                    stopWatch = new Stopwatch( );
                    stopWatch.Start( );
                }
                else
                {
                    stopWatch.Stop( );

                    float fps = 1000.0f * framesReceived / stopWatch.ElapsedMilliseconds;
                    fpsLabel.Text = fps.ToString( "F2" ) + " fps";

                    stopWatch.Reset( );
                    stopWatch.Start( );
                }
            }
            logBox.Text = s;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }
    }
}
