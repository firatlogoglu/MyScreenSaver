using MyScreenSaver.Languages;
using MyScreenSaver.Methods;
using MyScreenSaver.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class OptionsForm : Form
    {
        private bool cmbBoxLangsec;

        public OptionsForm()
        {
            InitializeComponent();
            GetLanguagesList();
            GetSettings();
            GetPictureDirs();
            GetPictureExtensions();
            GetMusicDirs();
            GetMusicExtensions();
            GetVideoDirs();
            GetVideoExtensions();
            Lang();
        }

        private void GetSettings()
        {
            cmbBoxLang.SelectedItem = Settings.Default.Language;
            cmbBoxLangsec = true;
            chkBoxMouseDbClick.Checked = Settings.Default.AppCloseMouseDbClick;
            chkBoxPictureAuto.Checked = Settings.Default.PictureAuto;
            chkBoxShowTime.Checked = Settings.Default.ShowTime;
            chkBoxMusicPlayer.Checked = Settings.Default.MusicPlayer;
            chkBoxShowClockAndDate.Checked = Settings.Default.ClockAndDate;
            chkBoxRememberRemoveFileList.Checked = Settings.Default.RememberRemoveFileList;

            txtboxTime.Enabled = Settings.Default.PictureAuto;
            txtboxTime.Text = Settings.Default.PictureTime.ToString();
            if (Settings.Default.MusicPlayer)
            {
                grpBoxMusicPlayer.Enabled = true;
                radioBtnWMP2.Enabled = true;
                radioBtnVLC2.Enabled = true;
            }
            else
            {
                grpBoxMusicPlayer.Enabled = false;
                radioBtnWMP2.Enabled = false;
                radioBtnVLC2.Enabled = false;
            }


            if (Settings.Default.ImageSlideshow)
            {
                radioBtnImageSlideshow.Checked = true;
                radioBtnVideoSlideshow.Checked = false;
                grpBoxPictureSlideShow.Enabled = true;
                grpBoxVideoSlideShow.Enabled = false;
            }
            else
            {
                radioBtnImageSlideshow.Checked = false;
                radioBtnVideoSlideshow.Checked = true;
                grpBoxPictureSlideShow.Enabled = false;
                grpBoxVideoSlideShow.Enabled = true;
            }

            if (Settings.Default.VideoAppWMP)
            {
                radioBtnWMP.Checked = true;
                radioBtnVLC.Checked = false;
            }
            else
            {
                radioBtnVLC.Checked = true;
                radioBtnWMP.Checked = false;
            }

            if (Settings.Default.MusicAppWMP)
            {
                radioBtnWMP2.Checked = true;
                radioBtnVLC2.Checked = false;
            }
            else
            {
                radioBtnVLC2.Checked = true;
                radioBtnWMP2.Checked = false;
            }
        }

        private void GetLanguagesList()
        {
            object[] ob = SettingsMethods.GetAllLanguageDisplayNames();
            cmbBoxLang.Items.AddRange(ob);
        }

        private void GetPictureDirs()
        {
            try
            {
                foreach (var item in Settings.Default.PictureDir)
                {
                    listboxPictureDirs.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetPictureExtensions()
        {
            try
            {
                foreach (var item in Settings.Default.PictureExtensions)
                {
                    listboxPictureExtensions.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetMusicDirs()
        {
            try
            {
                foreach (var item in Settings.Default.MusicDir)
                {
                    listboxMusicDirs.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetMusicExtensions()
        {
            try
            {
                foreach (var item in Settings.Default.MusicExtensions)
                {
                    listboxMusicExtensions.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetVideoDirs()
        {
            try
            {
                foreach (var item in Settings.Default.VideoDir)
                {
                    listboxVideoDirs.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetVideoExtensions()
        {
            try
            {
                foreach (var item in Settings.Default.VideoExtensions)
                {
                    listboxVideoExtensions.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Lang()
        {
            this.Text = Localization.Settings;

            lbLang.Text = Localization.Language;
            lblSec.Text = Localization.seconds;
            lblTime.Text = Localization.Time;

            btnOpenUpdateManager.Text = Localization.OpenUpdateManager;

            grpBoxGeneralSettings.Text = Localization.GeneralSettings;
            grpBoxPictureSlideShow.Text = Localization.ImageSlideshow;
            grpBoxSlideShowAndTime.Text = Localization.TTime;
            grpBoxPictureExtension.Text = Localization.FileTypes;
            grpBoxPictureDirList.Text = Localization.ListofImageFolders;

            grpBoxMusicPlayer.Text = Localization.MusicPlayer;
            grpBoxMusicExtension.Text = Localization.FileTypes;
            grpBoxMusicDirList.Text = Localization.ListofMusicFolders;

            grpBoxVideoSlideShow.Text = Localization.VideoSlideshow;
            grpBoxVideoExtension.Text = Localization.FileTypes;
            grpBoxVideoDirList.Text = Localization.ListofVideoFolders;

            btnAdd.Text = Localization.Add;
            btnRemove.Text = Localization.Remove;
            btnAllRemove.Text = Localization.AllRemove;
            btnDefault.Text = Localization.Default;

            btnAddPictureExtension.Text = Localization.Add;
            btnRemovePictureExtension.Text = Localization.Remove;
            btnAllRemovePictureExtension.Text = Localization.AllRemove;
            btnPictureExtensionDefault.Text = Localization.Default;

            btnAddMusic.Text = Localization.Add;
            btnRemoveMusic.Text = Localization.Remove;
            btnAllRemoveMusic.Text = Localization.AllRemove;
            btnDefaultMusic.Text = Localization.Default;

            btnAddMusicExtension.Text = Localization.Add;
            btnRemoveMusicExtension.Text = Localization.Remove;
            btnAllRemoveMusicExtension.Text = Localization.AllRemove;
            btnMusicExtensionDefault.Text = Localization.Default;

            btnShow.Text = Localization.Show;
            btnOK.Text = Localization.OK;

            chkBoxMouseDbClick.Text = Localization.ExitMouseDbClick;
            chkBoxPictureAuto.Text = Localization.PictureAuto;
            chkBoxShowTime.Text = Localization.ShowTime;
            chkBoxMusicPlayer.Text = Localization.MusicPlayerEnabled;
            chkBoxShowClockAndDate.Text = Localization.ShowClockAndDate;
            chkBoxRememberRemoveFileList.Text = Localization.RememberRemoveFileList;

            radioBtnImageSlideshow.Text = Localization.ImageSlideshow;
            radioBtnVideoSlideshow.Text = Localization.VideoSlideshow;

            radioBtnWMP.Text = Localization.WMP;
            radioBtnVLC.Text = Localization.VLC;

            btnAddVideo.Text = Localization.Add;
            btnRemoveVideo.Text = Localization.Remove;
            btnAllRemoveVideo.Text = Localization.AllRemove;
            btnDefaultVideo.Text = Localization.Default;

            btnAddVideoExtension.Text = Localization.Add;
            btnRemoveVideoExtension.Text = Localization.Remove;
            btnAllRemoveVideoExtension.Text = Localization.AllRemove;
            btnVideoExtensionDefault.Text = Localization.Default;
        }

        private void chkBoxMouseDbClick_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.SetAppCloseMouseDbClick(chkBoxMouseDbClick.Checked);
        }

        private void chkBoxShowTime_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.ChkBoxShowTime(chkBoxShowTime.Checked);
        }

        private void cmbBoxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxLangsec)
            {
                if (cmbBoxLang.Text == SettingsMethods.GetLanguageDisplayName(AllLanguageCodes.TurkishCodeTR))
                {
                    SettingsMethods.SetLanguage(AllLanguageCodes.TurkishCodeTR);
                }
                else if (cmbBoxLang.Text == SettingsMethods.GetLanguageDisplayName(AllLanguageCodes.EnglishCodeUS))
                {
                    SettingsMethods.SetLanguage(AllLanguageCodes.EnglishCodeUS);
                }
                else if (cmbBoxLang.Text == SettingsMethods.GetLanguageDisplayName(AllLanguageCodes.EnglishCodeGB_UK))
                {
                    SettingsMethods.SetLanguage(AllLanguageCodes.EnglishCodeGB_UK);
                }
                else
                {
                    SettingsMethods.SetLanguage(AllLanguageCodes.EnglishCodeGB_UK);
                }
            }
        }

        private void lbLang_SizeChanged(object sender, EventArgs e)
        {
            cmbBoxLang.Location = new Point(lbLang.Size.Width + 8, cmbBoxLang.Location.Y);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listboxPictureDirs.Items.Add(folderBrowserDialog.SelectedPath);
                SettingsMethods.AddPictureDirs(folderBrowserDialog.SelectedPath);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsMethods.RemovePictureDir(listboxPictureDirs.SelectedIndex);
                listboxPictureDirs.Items.RemoveAt(listboxPictureDirs.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllRemove_Click(object sender, EventArgs e)
        {
            listboxPictureDirs.Items.Clear();
            SettingsMethods.AllRemovePictureDirs();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            string defaultuser = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            listboxPictureDirs.Items.Clear();
            listboxPictureDirs.Items.Add(defaultuser);
            SettingsMethods.DefaultPictureDirs(defaultuser);
        }

        private void btnAddPictureExtension_Click(object sender, EventArgs e)
        {
            string ex = string.Format("*.{0}*", txtboxPictureExtension.Text);
            if (!listboxPictureExtensions.Items.Contains(ex) && txtboxPictureExtension.Text != null && txtboxPictureExtension.Text != "")
            {
                listboxPictureExtensions.Items.Add(ex);
                SettingsMethods.AddPictureExtension(ex);
                txtboxPictureExtension.Text = null;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowScreenSaverForm screenSaverForm = new ShowScreenSaverForm();
            screenSaverForm.Show();
        }

        private void txtboxTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SettingsMethods.SetTimePicture(Convert.ToInt32(txtboxTime.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkBoxPictureAuto_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.SetPictureAuto(chkBoxPictureAuto.Checked);
            txtboxTime.Enabled = Settings.Default.PictureAuto;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemovePictureExtension_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsMethods.RemovePictureExtension(listboxPictureExtensions.SelectedIndex);
                listboxPictureExtensions.Items.RemoveAt(listboxPictureExtensions.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllRemovePictureExtension_Click(object sender, EventArgs e)
        {
            listboxPictureExtensions.Items.Clear();
            SettingsMethods.AllRemovePictureExtensions();
        }

        private void btnPictureExtensionDefault_Click(object sender, EventArgs e)
        {
            string[] ex = { "*.jpg*", "*.png*" };

            listboxPictureExtensions.Items.Clear();
            listboxPictureExtensions.Items.AddRange(ex);
            SettingsMethods.DefaultPictureExtension(ex);
        }

        private void btnDefaultMusic_Click(object sender, EventArgs e)
        {
            string defaultuser = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            listboxMusicDirs.Items.Clear();
            listboxMusicDirs.Items.Add(defaultuser);
            SettingsMethods.DefaultMusicDirs(defaultuser);
        }

        private void chkBoxMusicPlayer_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.ChkBoxMusicPlayer(chkBoxMusicPlayer.Checked);
            grpBoxMusicPlayer.Enabled = Settings.Default.MusicPlayer;
            radioBtnWMP2.Enabled = Settings.Default.MusicPlayer;
            radioBtnVLC2.Enabled = Settings.Default.MusicPlayer;
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listboxMusicDirs.Items.Add(folderBrowserDialog.SelectedPath);
                SettingsMethods.AddMusicDirs(folderBrowserDialog.SelectedPath);
            }
        }

        private void btnRemoveMusic_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsMethods.RemoveMusicDir(listboxMusicDirs.SelectedIndex);
                listboxMusicDirs.Items.RemoveAt(listboxMusicDirs.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllRemoveMusic_Click(object sender, EventArgs e)
        {
            listboxMusicDirs.Items.Clear();
            SettingsMethods.AllRemoveMusicDirs();
        }

        private void btnMusicExtensionDefault_Click(object sender, EventArgs e)
        {
            string[] ex = { "*.mp3*", "*.wav*", "*.midi*" };

            listboxMusicExtensions.Items.Clear();
            listboxMusicExtensions.Items.AddRange(ex);
            SettingsMethods.DefaultMusicExtension(ex);
        }

        private void btnAddMusicExtension_Click(object sender, EventArgs e)
        {
            string ex = string.Format("*.{0}*", txtboxMusicExtension.Text);
            if (!listboxMusicExtensions.Items.Contains(ex) && txtboxMusicExtension.Text != null && txtboxMusicExtension.Text != "")
            {
                listboxMusicExtensions.Items.Add(ex);
                SettingsMethods.AddMusicExtension(ex);
                txtboxMusicExtension.Text = null;
            }
        }

        private void btnRemoveMusicExtension_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsMethods.RemoveMusicExtension(listboxMusicExtensions.SelectedIndex);
                listboxMusicExtensions.Items.RemoveAt(listboxMusicExtensions.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllRemoveMusicExtension_Click(object sender, EventArgs e)
        {
            listboxMusicExtensions.Items.Clear();
            SettingsMethods.AllRemoveMusicExtensions();
        }

        private void radioBtnImageSlideshow_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.RadioBtnImageSlideshow(radioBtnImageSlideshow.Checked);
            grpBoxPictureSlideShow.Enabled = true;
            grpBoxVideoSlideShow.Enabled = false;
        }

        private void radioBtnVideoSlideshow_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.RadioBtnImageSlideshow(radioBtnImageSlideshow.Checked);
            grpBoxPictureSlideShow.Enabled = false;
            grpBoxVideoSlideShow.Enabled = true;
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listboxVideoDirs.Items.Add(folderBrowserDialog.SelectedPath);
                SettingsMethods.AddVideoDirs(folderBrowserDialog.SelectedPath);
            }

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //string filter = "Video Files";
            //foreach (var item in listboxVideoExtensions.Items)
            //{

            //}
            //filter += String.Format(" ({0})|{0}", "*.mkv");
            //openFileDialog.Filter = filter;
            ////"txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //if (openFileDialog.ShowDialog()==DialogResult.OK)
            //{
            //    listboxVideoDirs.Items.Add(openFileDialog.FileName);
            //    SettingsMethods.AddVideoDirs(openFileDialog.FileName);
            //}

        }

        private void btnRemoveVideo_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsMethods.RemoveVideoDir(listboxVideoDirs.SelectedIndex);
                listboxVideoDirs.Items.RemoveAt(listboxVideoDirs.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllRemoveVideo_Click(object sender, EventArgs e)
        {
            listboxVideoDirs.Items.Clear();
            SettingsMethods.AllRemoveVideoDirs();
        }

        private void btnDefaultVideo_Click(object sender, EventArgs e)
        {
            string defaultuser = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            listboxVideoDirs.Items.Clear();
            listboxVideoDirs.Items.Add(defaultuser);
            SettingsMethods.DefaultVideoDirs(defaultuser);
        }

        private void btnAddVideoExtension_Click(object sender, EventArgs e)
        {
            string ex = string.Format("*.{0}*", txtboxVideoExtension.Text);
            if (!listboxVideoExtensions.Items.Contains(ex) && txtboxVideoExtension.Text != null && txtboxVideoExtension.Text != "")
            {
                listboxVideoExtensions.Items.Add(ex);
                SettingsMethods.AddVideoExtension(ex);
                txtboxVideoExtension.Text = null;
            }
        }

        private void btnRemoveVideoExtension_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsMethods.RemoveVideoExtension(listboxVideoExtensions.SelectedIndex);
                listboxVideoExtensions.Items.RemoveAt(listboxVideoExtensions.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllRemoveVideoExtension_Click(object sender, EventArgs e)
        {
            listboxVideoExtensions.Items.Clear();
            SettingsMethods.AllRemoveVideoExtensions();
        }

        private void btnVideoExtensionDefault_Click(object sender, EventArgs e)
        {
            string[] ex = { "*.mp4*", "*.avi*", "*.mkv*", "*.wmv*", "*.mpg*", "*.mpeg*", "*.rm*", "*.rmvb*", };

            listboxVideoExtensions.Items.Clear();
            listboxVideoExtensions.Items.AddRange(ex);
            SettingsMethods.DefaultVideoExtension(ex);
        }

        private void chkBoxShowClockAndDate_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.SetClockAndDate(chkBoxShowClockAndDate.Checked);
        }

        private void radioBtnWMP_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.RadioBtnWPA(radioBtnWMP.Checked);
        }

        private void radioBtnVLC_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.RadioBtnWPA(radioBtnWMP.Checked);
        }

        private void chkBoxRememberRemoveFileList_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.SetRememberRemoveFileList(chkBoxRememberRemoveFileList.Checked);
        }


        private void btnOpenUpdateManager_Click(object sender, EventArgs e)
        {
            UpdateManager.UpdateManagerForm updateManagerForm = new UpdateManager.UpdateManagerForm("https://raw.githubusercontent.com/firatlogoglu/MyScreenSaver/master/NEWVERSION", "https://github.com/firatlogoglu/MyScreenSaver/releases/");
            updateManagerForm.ShowDialog();
        }

        private void radioBtnWMP2_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.RadioBtnWPA2(radioBtnWMP2.Checked);
        }

        private void radioBtnVLC2_CheckedChanged(object sender, EventArgs e)
        {
            SettingsMethods.RadioBtnWPA2(radioBtnWMP2.Checked);
        }
    }
}