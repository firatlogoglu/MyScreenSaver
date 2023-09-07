using MyScreenSaver.Languages;
using MyScreenSaver.Models.WMP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class VideoPlayerWMPForm : Form
    {
        private List<string> videofiles = new List<string>();
        private static List<string> video_extensions = new List<string>();

        private int i;
        private bool playing;
        private int msplayerstatus;
        private bool error = false;
        private string lastErrorFilePath;
        public VideoPlayerWMPForm()
        {
            InitializeComponent();
            GetSettings();
        }

        private void GetSettings()
        {
            this.Text = Localization.VideoSlideshow;
            listBoxVideoList.Location = new System.Drawing.Point(1600, 0);
            listBoxVideoList.Enabled = false;
            axWindowsMediaPlayer.Ctlenabled = true;
            listBoxVideoList.Visible = false;

            try
            {
                foreach (var item in Properties.Settings.Default.VideoExtensions)
                {
                    video_extensions.Add(item);
                }

                foreach (var item in Properties.Settings.Default.VideoDir)
                {
                    videofiles.AddRange(SearchForVideoFiles(item));
                }

                listBoxVideoList.DataSource = videofiles;
                axWindowsMediaPlayer.URL = videofiles[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ShowOptionsForm()
        {
            OptionsForm options = new OptionsForm();
            options.ShowDialog();

            if (Properties.Settings.Default.ImageSlideshow || !Properties.Settings.Default.VideoAppWMP)
            {
                Application.Restart();
            }
            else
            {
                i = 0;
                videofiles.Clear();
                video_extensions.Clear();
                lblVideoBox.Text = Localization.Loading;
                axWindowsMediaPlayer.Ctlcontrols.stop();
                listBoxVideoList.DataSource = null;
                GetSettings();
            }
        }

        static List<string> SearchForVideoFiles(string directory)
        {
            var videoFiles = new List<string>();

            try
            {
                foreach (string ext in video_extensions)
                {
                    foreach (string filePath in Directory.GetFiles(directory, ext))
                    {
                        videoFiles.Add(filePath);
                    }
                }

                foreach (string subDirectory in Directory.GetDirectories(directory))
                {
                    try
                    {
                        videoFiles.AddRange(SearchForVideoFiles(subDirectory));
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // MessageBox.Show(ex.Message);
            }

            return videoFiles;
        }

        private void ShowVideoList()
        {
            if (listBoxVideoList.Enabled == false)
            {
                listBoxVideoList.SelectedItem = axWindowsMediaPlayer.Ctlcontrols.currentItem;
                listBoxVideoList.Enabled = true;
                listBoxVideoList.Visible = true;

                //panel1.Enabled = false;
            }
            else
            {
                listBoxVideoList.Enabled = false;
                listBoxVideoList.Visible = false;
            }
        }

        private void PlayVideo()
        {
            try
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PauseVideo()
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void StopVideo()
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void NextVideo()
        {
            try
            {
                if (!error)
                {
                    if (i == videofiles.Count - 1)
                    {
                        i = 0;
                        axWindowsMediaPlayer.URL = videofiles[0];
                    }
                    else
                    {
                        i = i + 1;
                        axWindowsMediaPlayer.URL = videofiles[i];
                    }
                }
                else
                {
                    axWindowsMediaPlayer.URL = videofiles[i];
                }

            }
            catch (Exception ex)
            {
                if (ex.HResult == -1072885577)
                {

                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PreviousVideo()
        {
            if (i == 0)
            {
                i = videofiles.Count - 1;
                axWindowsMediaPlayer.URL = videofiles[i];
            }
            else
            {
                i = i - 1;
                axWindowsMediaPlayer.URL = videofiles[i];
            }
        }

        private void VideoPlayerForm_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardKeyDown(e);
        }

        private void listBoxVideoList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer.URL = videofiles[(listBoxVideoList.SelectedIndex)];
            i = listBoxVideoList.SelectedIndex;
        }

        private void KeyboardKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyData == Keys.F1)
            {
                ShowOptionsForm();
            }
            else if (e.KeyData == Keys.MediaPlayPause || e.KeyData == Keys.Space)
            {
                if (playing)
                {
                    PauseVideo();
                }
                else
                {
                    PlayVideo();
                }
            }
            else if (e.KeyData == Keys.MediaStop || e.KeyData == Keys.Enter)
            {
                StopVideo();
            }
            else if (e.KeyData == Keys.MediaNextTrack || e.KeyData == Keys.Right)
            {
                NextVideo();
            }
            else if (e.KeyData == Keys.MediaPreviousTrack || e.KeyData == Keys.Left)
            {
                PreviousVideo();
            }
            else if (e.KeyData == Keys.L)
            {
                ShowVideoList();
            }
        }

        private void listBoxVideoList_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardKeyDown(e);
        }

        private void lblVideoBox_Click(object sender, EventArgs e)
        {
            ShowVideoList();
        }

        private void axWindowsMediaPlayer_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            if (Properties.Settings.Default.AppCloseMouseDbClick)
            {
                Application.Exit();
            }
        }

        private int z = 0;
        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            msplayerstatus = e.newState;
            if (e.newState == ((int)PlayStates.Stopped))
            {
                playing = false;
            }
            else if (e.newState == ((int)PlayStates.Paused))
            {
                playing = false;
            }
            else if (e.newState == ((int)PlayStates.Playing))
            {
                playing = true;
                error = false;

                try
                {
                    if (i == -1)
                    {
                        axWindowsMediaPlayer.URL = videofiles[(z + 1)];
                    }
                    else
                    {
                        z = i;
                    }
                    lblVideoBox.Text = string.Format("{0} {1}/{2}", videofiles[i], i + 1, videofiles.Count);

                    listBoxVideoList.SelectedIndex = i;
                }
                catch (Exception ex)
                {
                    //PauseVideo();
                    MessageBox.Show(ex.Message);
                    //PreviousVideo();
                }
            }
            else if (e.newState == ((int)PlayStates.MediaEnded))
            {
                timer.Start();
                NextVideo();
                //PlayVideo();
            }
            else if (e.newState == (int)PlayStates.Ready)
            {
                if (error)
                {
                    timer.Start();
                    NextVideo();
                }
            }
            else if (e.newState == (int)PlayStates.Transitioning)
            {
                var assss = axWindowsMediaPlayer;
            }
        }

        private void axWindowsMediaPlayer_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if (e.nKeyCode == 27)
            {
                Application.Exit();
            }
            else if (e.nKeyCode == 112)
            {
                ShowOptionsForm();
            }
            else if (/*e.nKeyCode == 179 ||*/e.nKeyCode == 32)
            {
                if (playing)
                {
                    PauseVideo();
                }
                else
                {
                    PlayVideo();
                }
            }
            else if (e.nKeyCode == 178)
            {
                StopVideo();
            }
            else if (e.nKeyCode == 176 || e.nKeyCode == 71)
            {
                NextVideo();
            }
            else if (e.nKeyCode == 177 || e.nKeyCode == 37 || e.nKeyCode == 70)
            {
                PreviousVideo();
            }
            else if (e.nKeyCode == 76 || e.nKeyCode == 39)
            {
                ShowVideoList();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (msplayerstatus == (int)PlayStates.Ready)
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
                timer.Stop();
            }
        }

        private void axWindowsMediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            string errorFilePath = videofiles[i];

            lblVideoBox.ForeColor = System.Drawing.Color.Red;
            lblVideoBox.Text = string.Format("{0}: {1} {2}/{3}", Localization.ERROR_2, errorFilePath, i + 1, videofiles.Count);

            DialogResult dialogResult = new DialogResult();
            int a = 0;
            try
            {
                a = axWindowsMediaPlayer.Error.get_Item(0).errorCode;
                //string e0 = axWindowsMediaPlayer.Error.get_Item(0).errorDescription + " " + axWindowsMediaPlayer.Error.get_Item(0).customUrl;
                //string e1 = axWindowsMediaPlayer.Error.get_Item(1).errorDescription + " " + axWindowsMediaPlayer.Error.get_Item(1).customUrl;
                //string e2 = axWindowsMediaPlayer.Error.get_Item(2).errorDescription + " " + axWindowsMediaPlayer.Error.get_Item(2).customUrl;
                //string e3 = axWindowsMediaPlayer.Error.get_Item(3).errorDescription + " " + axWindowsMediaPlayer.Error.get_Item(3).customUrl;
                axWindowsMediaPlayer.Error.clearErrorQueue();
                //MessageBox.Show(e0 + " " + errorFilePath + " " + lastErrorFilePath);
                //MessageBox.Show("E1: " + e1);
                //MessageBox.Show("E2: " + e2);
                //MessageBox.Show("E3: " + e3);
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147024809)
                {

                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }


            if (a == -1072885353 && lastErrorFilePath != errorFilePath || string.IsNullOrEmpty(lastErrorFilePath))
            {
                axWindowsMediaPlayer.Error.clearErrorQueue();
                error = true;
                lastErrorFilePath = errorFilePath;

                dialogResult = MessageBox.Show(i + ".) " + videofiles[i] + Localization.Delete_File_List, Localization.RemoveFile, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            }

            if (dialogResult == DialogResult.Yes || Properties.Settings.Default.RememberRemoveFileList)
            {
                axWindowsMediaPlayer.Error.clearErrorQueue();
                listBoxVideoList.DataSource = null;
                videofiles.RemoveAt(i);
                listBoxVideoList.DataSource = videofiles;

                timer.Start();
                lblVideoBox.ForeColor = System.Drawing.Color.Black;
                NextVideo();
            }
            else if (dialogResult == DialogResult.No)
            {
                axWindowsMediaPlayer.Error.clearErrorQueue();
                listBoxVideoList.DataSource = null;
                videofiles[i] = Localization.ERROR_FILE + videofiles[i];
                listBoxVideoList.DataSource = videofiles;
                videofiles[i] = errorFilePath;

                timer.Start();
                lblVideoBox.ForeColor = System.Drawing.Color.Black;
                NextVideo();
            }
            else/*(dialogResult == DialogResult.Cancel)*/
            {
                error = false;
                axWindowsMediaPlayer.Error.clearErrorQueue();
            }
        }

        private void VideoPlayerWMPForm_Load(object sender, EventArgs e)
        {
            //GetSettings();
        }
    }
}