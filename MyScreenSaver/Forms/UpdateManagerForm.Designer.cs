
namespace MyScreenSaver.Forms
{
    partial class UpdateManagerForm
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
            this.btnInstallUpdates = new System.Windows.Forms.Button();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.lblANewVersionAva = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDownloadUpdates = new System.Windows.Forms.Button();
            this.lnkLblDirectDownload = new System.Windows.Forms.LinkLabel();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstallUpdates
            // 
            this.btnInstallUpdates.AutoSize = true;
            this.btnInstallUpdates.Enabled = false;
            this.btnInstallUpdates.Location = new System.Drawing.Point(12, 154);
            this.btnInstallUpdates.Name = "btnInstallUpdates";
            this.btnInstallUpdates.Size = new System.Drawing.Size(132, 23);
            this.btnInstallUpdates.TabIndex = 0;
            this.btnInstallUpdates.Text = "Güncellemeri &Kur";
            this.btnInstallUpdates.UseVisualStyleBackColor = true;
            this.btnInstallUpdates.Click += new System.EventHandler(this.btnInstallUpdates_Click);
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(12, 46);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(76, 13);
            this.lblCurrentVersion.TabIndex = 1;
            this.lblCurrentVersion.Text = "Geçerli Sürüm:";
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.AutoSize = true;
            this.lblNewVersion.Location = new System.Drawing.Point(12, 59);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Size = new System.Drawing.Size(64, 13);
            this.lblNewVersion.TabIndex = 1;
            this.lblNewVersion.Text = "Yeni Sürüm:";
            // 
            // lblANewVersionAva
            // 
            this.lblANewVersionAva.AutoSize = true;
            this.lblANewVersionAva.Location = new System.Drawing.Point(12, 9);
            this.lblANewVersionAva.Name = "lblANewVersionAva";
            this.lblANewVersionAva.Size = new System.Drawing.Size(118, 13);
            this.lblANewVersionAva.TabIndex = 2;
            this.lblANewVersionAva.Text = "Yeni Bir Sürüm Mevcut.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 197);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(251, 23);
            this.progressBar.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 227);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // btnDownloadUpdates
            // 
            this.btnDownloadUpdates.AutoSize = true;
            this.btnDownloadUpdates.Enabled = false;
            this.btnDownloadUpdates.Location = new System.Drawing.Point(12, 120);
            this.btnDownloadUpdates.Name = "btnDownloadUpdates";
            this.btnDownloadUpdates.Size = new System.Drawing.Size(132, 23);
            this.btnDownloadUpdates.TabIndex = 5;
            this.btnDownloadUpdates.Text = "Güncellemeleri &İndir";
            this.btnDownloadUpdates.UseVisualStyleBackColor = true;
            this.btnDownloadUpdates.Click += new System.EventHandler(this.btnDownloadUpdates_Click);
            // 
            // lnkLblDirectDownload
            // 
            this.lnkLblDirectDownload.AutoSize = true;
            this.lnkLblDirectDownload.Enabled = false;
            this.lnkLblDirectDownload.Location = new System.Drawing.Point(173, 159);
            this.lnkLblDirectDownload.Name = "lnkLblDirectDownload";
            this.lnkLblDirectDownload.Size = new System.Drawing.Size(77, 13);
            this.lnkLblDirectDownload.TabIndex = 6;
            this.lnkLblDirectDownload.TabStop = true;
            this.lnkLblDirectDownload.Text = "&Doğrudan İndir";
            this.lnkLblDirectDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblDirectDownload_LinkClicked);
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.AutoSize = true;
            this.btnCheckUpdates.Location = new System.Drawing.Point(11, 91);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Size = new System.Drawing.Size(135, 23);
            this.btnCheckUpdates.TabIndex = 5;
            this.btnCheckUpdates.Text = "Güncellemeleri Kontrol &Et";
            this.btnCheckUpdates.UseVisualStyleBackColor = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.btnCheckUpdates_Click);
            // 
            // UpdateManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 249);
            this.Controls.Add(this.lnkLblDirectDownload);
            this.Controls.Add(this.btnCheckUpdates);
            this.Controls.Add(this.btnDownloadUpdates);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblANewVersionAva);
            this.Controls.Add(this.lblNewVersion);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.btnInstallUpdates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateManagerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Güncelleme Yöneticisi";
            this.Load += new System.EventHandler(this.UpdateManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstallUpdates;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblNewVersion;
        private System.Windows.Forms.Label lblANewVersionAva;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDownloadUpdates;
        private System.Windows.Forms.LinkLabel lnkLblDirectDownload;
        private System.Windows.Forms.Button btnCheckUpdates;
    }
}