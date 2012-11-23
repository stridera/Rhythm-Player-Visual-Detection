namespace Player
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localVideoCaptureDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideofileusingDirectShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.orangeHist = new AForge.Controls.Histogram();
            this.blueHist = new AForge.Controls.Histogram();
            this.yellowHist = new AForge.Controls.Histogram();
            this.redHist = new AForge.Controls.Histogram();
            this.greenHist = new AForge.Controls.Histogram();
            this.orangeCol = new System.Windows.Forms.PictureBox();
            this.blueCol = new System.Windows.Forms.PictureBox();
            this.yellowCol = new System.Windows.Forms.PictureBox();
            this.redCol = new System.Windows.Forms.PictureBox();
            this.greenCol = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.logBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orangeCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1578, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localVideoCaptureDeviceToolStripMenuItem,
            this.openVideofileusingDirectShowToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // localVideoCaptureDeviceToolStripMenuItem
            // 
            this.localVideoCaptureDeviceToolStripMenuItem.Name = "localVideoCaptureDeviceToolStripMenuItem";
            this.localVideoCaptureDeviceToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.localVideoCaptureDeviceToolStripMenuItem.Text = "Local &Video Capture Device";
            this.localVideoCaptureDeviceToolStripMenuItem.Click += new System.EventHandler(this.localVideoCaptureDeviceToolStripMenuItem_Click);
            // 
            // openVideofileusingDirectShowToolStripMenuItem
            // 
            this.openVideofileusingDirectShowToolStripMenuItem.Name = "openVideofileusingDirectShowToolStripMenuItem";
            this.openVideofileusingDirectShowToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.openVideofileusingDirectShowToolStripMenuItem.Text = "Open video &file (for debugging)";
            this.openVideofileusingDirectShowToolStripMenuItem.Click += new System.EventHandler(this.openVideofileusingDirectShowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1578, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fpsLabel
            // 
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(1563, 17);
            this.fpsLabel.Spring = true;
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.logBox);
            this.mainPanel.Controls.Add(this.orangeHist);
            this.mainPanel.Controls.Add(this.blueHist);
            this.mainPanel.Controls.Add(this.yellowHist);
            this.mainPanel.Controls.Add(this.redHist);
            this.mainPanel.Controls.Add(this.greenHist);
            this.mainPanel.Controls.Add(this.orangeCol);
            this.mainPanel.Controls.Add(this.blueCol);
            this.mainPanel.Controls.Add(this.yellowCol);
            this.mainPanel.Controls.Add(this.redCol);
            this.mainPanel.Controls.Add(this.greenCol);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.videoSourcePlayer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1578, 555);
            this.mainPanel.TabIndex = 2;
            // 
            // orangeHist
            // 
            this.orangeHist.IsVertical = true;
            this.orangeHist.Location = new System.Drawing.Point(1497, 276);
            this.orangeHist.Name = "orangeHist";
            this.orangeHist.Size = new System.Drawing.Size(75, 270);
            this.orangeHist.TabIndex = 17;
            this.orangeHist.Text = "histogram5";
            this.orangeHist.Values = null;
            // 
            // blueHist
            // 
            this.blueHist.IsVertical = true;
            this.blueHist.Location = new System.Drawing.Point(1329, 273);
            this.blueHist.Name = "blueHist";
            this.blueHist.Size = new System.Drawing.Size(75, 270);
            this.blueHist.TabIndex = 16;
            this.blueHist.Text = "histogram4";
            this.blueHist.Values = null;
            // 
            // yellowHist
            // 
            this.yellowHist.IsVertical = true;
            this.yellowHist.Location = new System.Drawing.Point(1157, 273);
            this.yellowHist.Name = "yellowHist";
            this.yellowHist.Size = new System.Drawing.Size(75, 270);
            this.yellowHist.TabIndex = 15;
            this.yellowHist.Text = "histogram3";
            this.yellowHist.Values = null;
            // 
            // redHist
            // 
            this.redHist.IsVertical = true;
            this.redHist.Location = new System.Drawing.Point(988, 273);
            this.redHist.Name = "redHist";
            this.redHist.Size = new System.Drawing.Size(75, 270);
            this.redHist.TabIndex = 14;
            this.redHist.Text = "histogram2";
            this.redHist.Values = null;
            // 
            // greenHist
            // 
            this.greenHist.IsVertical = true;
            this.greenHist.Location = new System.Drawing.Point(817, 273);
            this.greenHist.Name = "greenHist";
            this.greenHist.Size = new System.Drawing.Size(75, 270);
            this.greenHist.TabIndex = 13;
            this.greenHist.Text = "histogram1";
            this.greenHist.Values = null;
            // 
            // orangeCol
            // 
            this.orangeCol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.orangeCol.Location = new System.Drawing.Point(1419, 273);
            this.orangeCol.Name = "orangeCol";
            this.orangeCol.Size = new System.Drawing.Size(72, 270);
            this.orangeCol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orangeCol.TabIndex = 10;
            this.orangeCol.TabStop = false;
            // 
            // blueCol
            // 
            this.blueCol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.blueCol.Location = new System.Drawing.Point(1251, 273);
            this.blueCol.Name = "blueCol";
            this.blueCol.Size = new System.Drawing.Size(72, 270);
            this.blueCol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueCol.TabIndex = 8;
            this.blueCol.TabStop = false;
            // 
            // yellowCol
            // 
            this.yellowCol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yellowCol.Location = new System.Drawing.Point(1079, 273);
            this.yellowCol.Name = "yellowCol";
            this.yellowCol.Size = new System.Drawing.Size(72, 270);
            this.yellowCol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowCol.TabIndex = 6;
            this.yellowCol.TabStop = false;
            // 
            // redCol
            // 
            this.redCol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.redCol.Location = new System.Drawing.Point(910, 273);
            this.redCol.Name = "redCol";
            this.redCol.Size = new System.Drawing.Size(72, 270);
            this.redCol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redCol.TabIndex = 4;
            this.redCol.TabStop = false;
            // 
            // greenCol
            // 
            this.greenCol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.greenCol.Location = new System.Drawing.Point(738, 273);
            this.greenCol.Name = "greenCol";
            this.greenCol.Size = new System.Drawing.Size(72, 270);
            this.greenCol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenCol.TabIndex = 2;
            this.greenCol.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(791, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(12, 3);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(720, 540);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog.Title = "Opem movie";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(1170, 0);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(396, 267);
            this.logBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 601);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Rhythm Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orangeCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localVideoCaptureDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.ToolStripMenuItem openVideofileusingDirectShowToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox orangeCol;
        private System.Windows.Forms.PictureBox blueCol;
        private System.Windows.Forms.PictureBox yellowCol;
        private System.Windows.Forms.PictureBox redCol;
        private System.Windows.Forms.PictureBox greenCol;
        private AForge.Controls.Histogram orangeHist;
        private AForge.Controls.Histogram blueHist;
        private AForge.Controls.Histogram yellowHist;
        private AForge.Controls.Histogram redHist;
        private AForge.Controls.Histogram greenHist;
        private System.Windows.Forms.TextBox logBox;
    }
}

