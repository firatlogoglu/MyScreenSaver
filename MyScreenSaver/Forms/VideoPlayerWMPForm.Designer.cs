
namespace MyScreenSaver
{
    partial class VideoPlayerWMPForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayerWMPForm));
            this.lblVideoBox = new System.Windows.Forms.Label();
            this.listBoxVideoList = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVideoBox
            // 
            this.lblVideoBox.AutoSize = true;
            this.lblVideoBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVideoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVideoBox.Location = new System.Drawing.Point(0, 434);
            this.lblVideoBox.Name = "lblVideoBox";
            this.lblVideoBox.Size = new System.Drawing.Size(17, 16);
            this.lblVideoBox.TabIndex = 1;
            this.lblVideoBox.Text = "...";
            this.lblVideoBox.Click += new System.EventHandler(this.lblVideoBox_Click);
            // 
            // listBoxVideoList
            // 
            this.listBoxVideoList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBoxVideoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxVideoList.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxVideoList.FormattingEnabled = true;
            this.listBoxVideoList.HorizontalScrollbar = true;
            this.listBoxVideoList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listBoxVideoList.Location = new System.Drawing.Point(485, 0);
            this.listBoxVideoList.Name = "listBoxVideoList";
            this.listBoxVideoList.ScrollAlwaysVisible = true;
            this.listBoxVideoList.Size = new System.Drawing.Size(315, 434);
            this.listBoxVideoList.TabIndex = 2;
            this.listBoxVideoList.TabStop = false;
            this.listBoxVideoList.UseTabStops = false;
            this.listBoxVideoList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxVideoList_KeyDown);
            this.listBoxVideoList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxVideoList_MouseDoubleClick);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(800, 434);
            this.axWindowsMediaPlayer.TabIndex = 3;
            this.axWindowsMediaPlayer.TabStop = false;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            this.axWindowsMediaPlayer.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.axWindowsMediaPlayer_MediaError);
            this.axWindowsMediaPlayer.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.axWindowsMediaPlayer_DoubleClickEvent);
            this.axWindowsMediaPlayer.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.axWindowsMediaPlayer_KeyDownEvent);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // VideoPlayerWMPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxVideoList);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.lblVideoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoPlayerWMPForm";
            this.Text = "VideoPlayerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VideoPlayerWMPForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayerForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVideoBox;
        private System.Windows.Forms.ListBox listBoxVideoList;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Timer timer;
    }
}