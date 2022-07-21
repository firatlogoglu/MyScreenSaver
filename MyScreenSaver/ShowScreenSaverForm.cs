using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class ShowScreenSaverForm : Form
    {
        //private List<Image> images = new List<Image>();
        private List<string> files = new List<string>();
        private bool pause = false;
        private int i = 0;
        private int z = 0;
        private int tick;

        public ShowScreenSaverForm()
        {
            InitializeComponent();
            GetSettings();
        }

        private void ImageLocation(string part)
        {
            try
            {
                pictureBox.ImageLocation = part;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ErrorImage()
        {
            pictureBox.Image = Properties.Resources.Error;
            lblpictureBox.Text = Localization.Error;
        }

        private void GetSettings()
        {
            List<string> extensions = new List<string>();
            lblTime.Visible = Properties.Settings.Default.ShowTime;
            try
            {
                foreach (var item in Properties.Settings.Default.PictureExtensions)
                {
                    extensions.Add(item);
                }

                foreach (var item in Properties.Settings.Default.PictureDir)
                {
                    var dosyalar = extensions.SelectMany(ext => new System.IO.DirectoryInfo(item).GetFiles(ext, System.IO.SearchOption.AllDirectories));
                    foreach (var item2 in dosyalar)
                    {
                        files.Add(item2.FullName);
                    }
                    z = dosyalar.Count();
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147024832)
                {
                    // -2147024832: "Belirtilen ağ adı artık geçersiz."
                    MessageBox.Show(ex.Message);

                    ShowOptionsForm();
                }
                else if (ex.HResult == -2147024893)
                {
                    MessageBox.Show(ex.Message);

                    ShowOptionsForm();
                }
                else
                {
                    MessageBox.Show(ex.Message);

                    ShowOptionsForm();
                }
            }
            if (z != 0)
            {
                ImageLocation(files[0]);
            }
            else
            {
                ErrorImage();
            }
        }

        private void PreviousPicture()
        {
            try
            {
                if (z != 0)
                {
                    ImageLocation(files[--i].ToString());
                    tick = 0;
                }
                else
                {
                    ErrorImage();
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233086)
                {
                    i = z - 1;
                    if (z != 0)
                    {
                        ImageLocation(files[i]);
                    }
                    else
                    {
                        ErrorImage();
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void NextPicture()
        {
            try
            {
                if (z != 0)
                {
                    ImageLocation(files[++i].ToString());
                    tick = 0;
                }
                else
                {
                    ErrorImage();
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233086)
                {
                    if (z != 0)
                    {
                        i = 0;
                        pictureBox.ImageLocation = files[i];
                    }
                    else
                    {
                        ErrorImage();
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PictureAuto()
        {
            if (Properties.Settings.Default.PictureAuto && !pause)
            {
                timer.Enabled = true;
                timer.Start();
            }
            else
            {
                timer.Stop();
                timer.Enabled = false;
            }
        }

        private void PausePicture()
        {
            if (Properties.Settings.Default.PictureAuto)
            {
                if (pause)
                {
                    timer.Start();
                    pause = false;
                }
                else
                {
                    timer.Stop();
                    pause = true;
                }
            }
            else
            {
                timer.Stop();
                timer.Enabled = false;
            }
        }

        private void ShowOptionsForm()
        {
            OptionsForm options = new OptionsForm();
            options.ShowDialog();
            files.Clear();
            i = 0;
            PictureAuto();
            GetSettings();
        }
        private void ShowScreenSaverForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.AppCloseMouseDbClick)
            {
                Application.Exit();
            }
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.AppCloseMouseDbClick)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                PreviousPicture();
            }
            else
            {
                NextPicture();
            }
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lblpictureBox.Text = string.Format("{0} {1}/{2}", pictureBox.ImageLocation, i + 1, files.Count);

            PictureAuto();
        }

        private void ShowScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyData == Keys.Left)
            {
                PreviousPicture();
            }
            else if (e.KeyData == Keys.Right)
            {
                NextPicture();
            }
            else if (e.KeyData == Keys.Space || e.KeyData == Keys.Pause)
            {
                PausePicture();
            }
            else if (e.KeyData == Keys.F1)
            {
                ShowOptionsForm();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tick++;
            lblTime.Text = tick.ToString();

            if (tick >= Properties.Settings.Default.PictureTime)
            {
                tick = 0;
                NextPicture();
            }
        }
    }
}