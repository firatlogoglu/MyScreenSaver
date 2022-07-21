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
            Lang();
        }

        private void GetSettings()
        {
            cmbBoxLang.SelectedItem = Settings.Default.Language;
            cmbBoxLangsec = true;
            chkBoxMouseDbClick.Checked = Settings.Default.AppCloseMouseDbClick;
            chkBoxPictureAuto.Checked = Settings.Default.PictureAuto;
            chkBoxShowTime.Checked = Settings.Default.ShowTime;
            txtboxTime.Enabled = Settings.Default.PictureAuto;
            txtboxTime.Text = Settings.Default.PictureTime.ToString();
        }

        private void GetLanguagesList()
        {
            cmbBoxLang.Items.Add(Languages.TurkishTR);
            cmbBoxLang.Items.Add(Languages.EnglishUS);
            cmbBoxLang.Items.Add(Languages.EnglishUK);
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

        private void Lang()
        {
            this.Text = Localization.Settings;

            lbLang.Text = Localization.Language;
            lblSec.Text = Localization.seconds;
            lblTime.Text = Localization.Time;

            grpBoxGeneralSettings.Text = Localization.GeneralSettings;
            grpBoxPictureSlideShow.Text = Localization.ImageSlideshow;
            grpBoxSlideShowAndTime.Text = Localization.TTime;
            grpBoxPictureExtension.Text = Localization.FileTypes;
            grpBoxPictureDirList.Text = Localization.ListofImageFolders;

            btnAdd.Text = Localization.Add;
            btnRemove.Text = Localization.Remove;
            btnAllRemove.Text = Localization.AllRemove;
            btnDefault.Text = Localization.Default;

            btnAddPictureExtension.Text = Localization.Add;
            btnRemovePictureExtension.Text = Localization.Remove;
            btnAllRemovePictureExtension.Text = Localization.AllRemove;
            btnPictureExtensionDefault.Text = Localization.Default;

            btnShow.Text = Localization.Show;
            btnOK.Text = Localization.OK;

            chkBoxMouseDbClick.Text = Localization.ExitMouseDbClick;
            chkBoxPictureAuto.Text = Localization.PictureAuto;
            chkBoxShowTime.Text = Localization.ShowTime;
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
                if (cmbBoxLang.Text == Languages.TurkishTR)
                {
                    SettingsMethods.SetLanguage(Languages.TurkishTR, "");
                }
                else if (cmbBoxLang.Text == Languages.EnglishUS)
                {
                    SettingsMethods.SetLanguage(Languages.EnglishUS, Languages.EnglishCodeUS);
                }
                else if (cmbBoxLang.Text == Languages.EnglishUK)
                {
                    SettingsMethods.SetLanguage(Languages.EnglishUK, Languages.EnglishCodeGB_UK);
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
            SettingsMethods.ChkBoxPictureAuto(chkBoxPictureAuto.Checked);
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
    }
}