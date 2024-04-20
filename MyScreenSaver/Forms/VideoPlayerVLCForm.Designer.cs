
namespace MyScreenSaver
{
    partial class VideoPlayerVLCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayerVLCForm));
            this.axVLCPlugin = new AxAXVLC.AxVLCPlugin2();
            this.lblVideoBox = new System.Windows.Forms.Label();
            this.listBoxVideoList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin
            // 
            this.axVLCPlugin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVLCPlugin.Enabled = true;
            this.axVLCPlugin.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin.Name = "axVLCPlugin";
            this.axVLCPlugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin.OcxState")));
            this.axVLCPlugin.Size = new System.Drawing.Size(800, 450);
            this.axVLCPlugin.TabIndex = 0;
            this.axVLCPlugin.TabStop = false;
            this.axVLCPlugin.MediaPlayerPlaying += new System.EventHandler(this.axVLCPlugin_MediaPlayerPlaying);
            this.axVLCPlugin.MediaPlayerPaused += new System.EventHandler(this.axVLCPlugin_MediaPlayerPaused);
            this.axVLCPlugin.MediaPlayerStopped += new System.EventHandler(this.axVLCPlugin_MediaPlayerStopped);
            this.axVLCPlugin.DblClick += new System.EventHandler(this.axVLCPlugin_DblClick);
            this.axVLCPlugin.KeyDownEvent += new AxAXVLC.DVLCEvents_KeyDownEventHandler(this.axVLCPlugin_KeyDownEvent);
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
            this.listBoxVideoList.Location = new System.Drawing.Point(167, 0);
            this.listBoxVideoList.Name = "listBoxVideoList";
            this.listBoxVideoList.ScrollAlwaysVisible = true;
            this.listBoxVideoList.Size = new System.Drawing.Size(633, 434);
            this.listBoxVideoList.TabIndex = 2;
            this.listBoxVideoList.TabStop = false;
            this.listBoxVideoList.UseTabStops = false;
            this.listBoxVideoList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxVideoList_KeyDown);
            this.listBoxVideoList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxVideoList_MouseDoubleClick);
            // 
            // VideoPlayerVLCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxVideoList);
            this.Controls.Add(this.lblVideoBox);
            this.Controls.Add(this.axVLCPlugin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoPlayerVLCForm";
            this.Text = "VideoPlayerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlayerForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin;
        private System.Windows.Forms.Label lblVideoBox;
        private System.Windows.Forms.ListBox listBoxVideoList;
    }
}