using MyScreenSaver.Languages;
using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using UpdateManager;

namespace MyScreenSaver.Forms
{
    public partial class UpdateManagerForm : Form
    {
        private readonly string productVersion = Application.ProductVersion;
        private readonly string startupPath = Application.StartupPath;
        private readonly bool is64BitProcess = Environment.Is64BitProcess;
        private string NewVersion;
        private string urlDownload;
        private string path;
        private double FileSize;
        private double Percentage;

        public UpdateManagerForm()
        {
            InitializeComponent();
            lblStatus.Text = "";
            Lang();
        }

        private void Lang()
        {
            this.Text = Localization.UpdateManager;

            lblNewVersion.Text = "";
            lblANewVersionAva.Text = "";
            btnCheckUpdates.Text = Localization.CheckUpdates;
            btnInstallUpdates.Text = Localization.InstallUpdates;
            btnDownloadUpdates.Text = Localization.DownloadUpdates;
            lnkLblDirectDownload.Text = Localization.DirectDownload;
            lblCurrentVersion.Text = Localization.CurrentVersion + " " + Application.ProductVersion + "\r\n";
        }

        private void CheckUpdate()
        {
            try
            {
                btnCheckUpdates.Enabled = false;
                lnkLblDirectDownload.Enabled = false;
                bool ass = UpdateManager.Update.Check(productVersion, is64BitProcess, "https://raw.githubusercontent.com/firatlogoglu/MyScreenSaver/master/NEWVERSION", "https://github.com/firatlogoglu/MyScreenSaver/releases/download/", "MyScreenSaver.Setup", startupPath, out string newVersion, out urlDownload, out path);

                if (ass)
                {
                    NewVersion = newVersion;
                    btnDownloadUpdates.Enabled = true;
                    btnCheckUpdates.Enabled = true;
                    lnkLblDirectDownload.Enabled = true;
                    lblANewVersionAva.Text = Localization.lblANewVersionAva + "\n" + Localization.lblANewVersionAva2;
                    lblNewVersion.Text = Localization.LastVersion + " " + newVersion;
                }
                else
                {
                    btnCheckUpdates.Enabled = true;
                    btnInstallUpdates.Enabled = false;
                    btnDownloadUpdates.Enabled = false;
                    lblANewVersionAva.Text = Localization.NoNewVersion;
                    lnkLblDirectDownload.Enabled = true;
                    lblNewVersion.Text = Localization.LastVersion + " " + ProductVersion;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblNewVersion.Text = Localization.LastVersion + " " + Localization.ERROR_2 + " " + Localization.LatestVersionNotDetected;
                lblANewVersionAva.Text = Localization.ERROR_2 + " " + Localization.LatestVersionNotDetected;
                lnkLblDirectDownload.Enabled = true;
                btnCheckUpdates.Enabled = true;
            }
        }

        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            CheckUpdate();
        }

        private void btnDownloadUpdates_Click(object sender, EventArgs e)
        {
            btnCheckUpdates.Enabled = false;
            btnDownloadUpdates.Enabled = false;

            Download.DownloadUpdates(urlDownload, path, WebDownloadFileCompleted, WebDownloadProgressChanged);
        }

        private void WebDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Minimum = 0;
            double receive = double.Parse(e.BytesReceived.ToString());
            FileSize = double.Parse(e.TotalBytesToReceive.ToString());
            Percentage = receive / FileSize * 100;
            lblStatus.Text = Localization.Downloading + $" { string.Format("{0:0.##}%", Percentage)}";
            progressBar.Value = int.Parse(Math.Truncate(Percentage).ToString());
            progressBar.Update();
        }

        private void WebDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                btnDownloadUpdates.Enabled = true;
            }
            else
            {
                lblStatus.Text = Localization.Downloaded + " " + "100%" + " " + Localization.TotalSize + $" {string.Format("{0:0.##} KB", FileSize / Percentage)}" + "\n\n" + path;
                btnDownloadUpdates.Enabled = false;
                btnInstallUpdates.Enabled = true;
            }
        }

        private void btnInstallUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                Install.InstallUpdates(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnkLblDirectDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Download.DirectDownload("https://github.com/firatlogoglu/MyScreenSaver/releases/latest", urlDownload);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateManagerForm_Load(object sender, EventArgs e)
        {
            //CheckUpdate();
        }
    }
}