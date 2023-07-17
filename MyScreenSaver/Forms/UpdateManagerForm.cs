using MyScreenSaver.Languages;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace MyScreenSaver.Forms
{
    public partial class UpdateManagerForm : Form
    {
        private WebClient webclient;
        private readonly string urlVersion = "https://raw.githubusercontent.com/firatlogoglu/MyScreenSaver/master/NEWVERSION";
        private string LastVersion;
        private string urlDownload;
        private string fileName;
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
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var newVersion = new WebClient().DownloadString(urlVersion);
                var currentVersion = Application.ProductVersion;
                newVersion = newVersion.Replace(".", "");
                currentVersion = currentVersion.Replace(".", "");
                if (Convert.ToInt32(newVersion) > Convert.ToInt32(currentVersion))
                {
                    btnCheckUpdates.Enabled = true;
                    LastVersion = (new WebClient().DownloadString(urlVersion));
                    urlDownload = string.Format("https://github.com/firatlogoglu/MyScreenSaver/releases/download/v{0}/MyScreenSaver.Setup_v{0}_x86.msi", LastVersion);
                    fileName = string.Format("MyScreenSaver.Setup_v{0}_x86.msi", LastVersion);
                    path = Application.StartupPath + "\\" + fileName;
                    btnDownloadUpdates.Enabled = true;
                    lblANewVersionAva.Text = Localization.lblANewVersionAva + "\n" + Localization.lblANewVersionAva2;
                    lblNewVersion.Text = Localization.LastVersion + " " + (new WebClient().DownloadString(urlVersion));
                    lnkLblDirectDownload.Enabled = true;
                }
                else
                {
                    btnCheckUpdates.Enabled = true;
                    btnInstallUpdates.Enabled = false;
                    btnDownloadUpdates.Enabled = false;
                    lblANewVersionAva.Text = Localization.NoNewVersion;
                    lnkLblDirectDownload.Enabled = true;
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
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            webclient = new WebClient();
            webclient.DownloadFileCompleted += WebDownloadFileCompleted;
            webclient.DownloadProgressChanged += WebDownloadProgressChanged;
            webclient.DownloadFileAsync(new Uri(urlDownload), path);
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
                lblStatus.Text = Localization.Downloaded + " " + "100%" + " " + Localization.TotalSize + $" {string.Format("{0:0.##} KB", FileSize / Percentage)}";
                btnDownloadUpdates.Enabled = false;
                btnInstallUpdates.Enabled = true;
            }
        }

        private void btnInstallUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                Process pr = new Process();
                pr.StartInfo.FileName = path;
                pr.StartInfo.Arguments = "";
                pr.StartInfo.UseShellExecute = true;
                pr.StartInfo.CreateNoWindow = false;

                pr.Start();
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
                if (string.IsNullOrWhiteSpace(urlDownload))
                {
                    urlDownload = "https://github.com/firatlogoglu/MyScreenSaver/releases/latest";
                }

                Process pr = new Process();
                pr.StartInfo.FileName = urlDownload;
                pr.Start();
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