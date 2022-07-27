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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWinMediaPlayer)).BeginInit();
            this.grpBoxMediaPlayer.SuspendLayout();
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
            // ShowScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmusicBox);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblpictureBox);
            this.Controls.Add(this.grpBoxMediaPlayer);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowScreenSaverForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowScreenSaverForm_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowScreenSaverForm_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWinMediaPlayer)).EndInit();
            this.grpBoxMediaPlayer.ResumeLayout(false);
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
    }
}

