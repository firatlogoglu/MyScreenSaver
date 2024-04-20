namespace MyScreenSaver
{
    partial class ShowScreenSaverForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowScreenSaverForm));
            this.lblpictureBox = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.axWinMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.grpBoxMediaPlayer = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblmusicBox = new System.Windows.Forms.Label();
            this.timerClockAndDate = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axVLCPlugin = new AxAXVLC.AxVLCPlugin2();
            this.listBoxMusicList = new System.Windows.Forms.ListBox();
            this.listBoxImageList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWinMediaPlayer)).BeginInit();
            this.grpBoxMediaPlayer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpictureBox
            // 
            this.lblpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblpictureBox.AutoSize = true;
            this.lblpictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.lblpictureBox.Location = new System.Drawing.Point(12, 428);
            this.lblpictureBox.Name = "lblpictureBox";
            this.lblpictureBox.Size = new System.Drawing.Size(16, 13);
            this.lblpictureBox.TabIndex = 1;
            this.lblpictureBox.Text = "...";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 450);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(775, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "0";
            // 
            // axWinMediaPlayer
            // 
            this.axWinMediaPlayer.Enabled = true;
            this.axWinMediaPlayer.Location = new System.Drawing.Point(6, 19);
            this.axWinMediaPlayer.Name = "axWinMediaPlayer";
            this.axWinMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWinMediaPlayer.OcxState")));
            this.axWinMediaPlayer.Size = new System.Drawing.Size(10, 212);
            this.axWinMediaPlayer.TabIndex = 3;
            this.axWinMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWinMediaPlayer_PlayStateChange);
            // 
            // grpBoxMediaPlayer
            // 
            this.grpBoxMediaPlayer.Controls.Add(this.axWinMediaPlayer);
            this.grpBoxMediaPlayer.Enabled = false;
            this.grpBoxMediaPlayer.Location = new System.Drawing.Point(782, 79);
            this.grpBoxMediaPlayer.Name = "grpBoxMediaPlayer";
            this.grpBoxMediaPlayer.Size = new System.Drawing.Size(18, 241);
            this.grpBoxMediaPlayer.TabIndex = 4;
            this.grpBoxMediaPlayer.TabStop = false;
            this.grpBoxMediaPlayer.Text = "Media Player";
            this.grpBoxMediaPlayer.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblmusicBox
            // 
            this.lblmusicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmusicBox.AutoSize = true;
            this.lblmusicBox.BackColor = System.Drawing.SystemColors.Window;
            this.lblmusicBox.Location = new System.Drawing.Point(12, 415);
            this.lblmusicBox.Name = "lblmusicBox";
            this.lblmusicBox.Size = new System.Drawing.Size(16, 13);
            this.lblmusicBox.TabIndex = 5;
            this.lblmusicBox.Text = "...";
            this.lblmusicBox.Visible = false;
            // 
            // timerClockAndDate
            // 
            this.timerClockAndDate.Tick += new System.EventHandler(this.timerClockAndDate_Tick);
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Enabled = false;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClock.ForeColor = System.Drawing.Color.Azure;
            this.lblClock.Location = new System.Drawing.Point(303, 9);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(158, 72);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:0000\r\n00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axVLCPlugin);
            this.panel1.Controls.Add(this.listBoxMusicList);
            this.panel1.Controls.Add(this.listBoxImageList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(461, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 450);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // axVLCPlugin
            // 
            this.axVLCPlugin.Enabled = true;
            this.axVLCPlugin.Location = new System.Drawing.Point(321, 147);
            this.axVLCPlugin.Name = "axVLCPlugin";
            this.axVLCPlugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin.OcxState")));
            this.axVLCPlugin.Size = new System.Drawing.Size(12, 240);
            this.axVLCPlugin.TabIndex = 1;
            this.axVLCPlugin.TabStop = false;
            this.axVLCPlugin.Visible = false;
            this.axVLCPlugin.MediaPlayerPlaying += new System.EventHandler(this.axVLCPlugin_MediaPlayerPlaying);
            this.axVLCPlugin.MediaPlayerPaused += new System.EventHandler(this.axVLCPlugin_MediaPlayerPaused);
            this.axVLCPlugin.MediaPlayerStopped += new System.EventHandler(this.axVLCPlugin_MediaPlayerStopped);
            // 
            // listBoxMusicList
            // 
            this.listBoxMusicList.FormattingEnabled = true;
            this.listBoxMusicList.HorizontalScrollbar = true;
            this.listBoxMusicList.Location = new System.Drawing.Point(152, 4);
            this.listBoxMusicList.Name = "listBoxMusicList";
            this.listBoxMusicList.ScrollAlwaysVisible = true;
            this.listBoxMusicList.Size = new System.Drawing.Size(181, 446);
            this.listBoxMusicList.TabIndex = 0;
            this.listBoxMusicList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxMusicList_KeyDown);
            this.listBoxMusicList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMusicList_MouseDoubleClick);
            // 
            // listBoxImageList
            // 
            this.listBoxImageList.FormattingEnabled = true;
            this.listBoxImageList.HorizontalScrollbar = true;
            this.listBoxImageList.Location = new System.Drawing.Point(6, 4);
            this.listBoxImageList.Name = "listBoxImageList";
            this.listBoxImageList.ScrollAlwaysVisible = true;
            this.listBoxImageList.Size = new System.Drawing.Size(140, 446);
            this.listBoxImageList.TabIndex = 0;
            this.listBoxImageList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxImageList_KeyDown);
            this.listBoxImageList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxImageList_MouseDoubleClick);
            // 
            // ShowScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblmusicBox);
            this.Controls.Add(this.lblpictureBox);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.grpBoxMediaPlayer);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowScreenSaverForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowScreenSaverForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowScreenSaverForm_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowScreenSaverForm_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWinMediaPlayer)).EndInit();
            this.grpBoxMediaPlayer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblpictureBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private AxWMPLib.AxWindowsMediaPlayer axWinMediaPlayer;
        private System.Windows.Forms.GroupBox grpBoxMediaPlayer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblmusicBox;
        private System.Windows.Forms.Timer timerClockAndDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxMusicList;
        private System.Windows.Forms.ListBox listBoxImageList;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin;
    }
}

