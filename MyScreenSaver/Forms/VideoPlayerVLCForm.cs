using MyScreenSaver.Languages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class VideoPlayerVLCForm : Form
    {
        private List<string> videofiles = new List<string>();
        private static List<string> video_extensions = new List<string>();
        private int z = 0;
        private bool playing;
        public VideoPlayerVLCForm()
        {
            InitializeComponent();
            GetSettings();
        }

        private void GetSettings()
        {
            this.Text = Localization.VideoSlideshow;
            listBoxVideoList.Location = new System.Drawing.Point(1600, 0);
            listBoxVideoList.Enabled = false;
            axVLCPlugin.Toolbar = false;
            axVLCPlugin.CtlVisible = false;
            axVLCPlugin.AutoPlay = true;
            axVLCPlugin.Show();
            listBoxVideoList.Visible = false;

            try
            {
                foreach (var item in Properties.Settings.Default.VideoExtensions)
                {
                    video_extensions.Add(item);
                }

                string fi = "file:///";

                foreach (var item in Properties.Settings.Default.VideoDir)
                {
                    try
                    {
                        videofiles.AddRange(SearchForVideoFiles(item));

                        try
                        {
                            foreach (var item2 in videofiles)
                            {
                                axVLCPlugin.playlist.add(fi + item2);
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        continue;
                    }
                }

                if(Properties.Settings.Default.VLC_URL != null)
                {
                    foreach (var item in Properties.Settings.Default.VLC_URL)
                    {
                        videofiles.Add(item);
                        axVLCPlugin.playlist.add(item);
                    }
                }

                PlayVideo();
                listBoxVideoList.DataSource = videofiles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void ShowOptionsForm()
        {
            OptionsForm options = new OptionsForm();
            options.ShowDialog();

            if (Properties.Settings.Default.ImageSlideshow || Properties.Settings.Default.VideoAppWMP)
            {
                Application.Restart();
            }
            else
            {
                z = 0;
                videofiles.Clear();
                video_extensions.Clear();
                axVLCPlugin.playlist.stop();
                axVLCPlugin.playlist.items.clear();
                listBoxVideoList.DataSource = null;
                GetSettings();
            }
        }

        private void ShowVideoList()
        {
            if (listBoxVideoList.Enabled == false)
            {
                listBoxVideoList.SelectedItem = axVLCPlugin.playlist.currentItem;
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
            axVLCPlugin.playlist.play();
        }

        private void PauseVideo()
        {
            axVLCPlugin.playlist.pause();
        }

        private void StopVideo()
        {
            axVLCPlugin.playlist.stop();
        }

        private void NextVideo()
        {
            axVLCPlugin.playlist.next();
        }

        private void PreviousVideo()
        {
            axVLCPlugin.playlist.prev();
        }

        private void VideoPlayerForm_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardKeyDown(e);
        }

        private void axVLCPlugin_KeyDownEvent(object sender, AxAXVLC.DVLCEvents_KeyDownEvent e)
        {
            if (e.keyCode == 27)
            {
                Application.Exit();
            }
            else if (e.keyCode == 112)
            {
                ShowOptionsForm();
            }
            else if (e.keyCode == 179 || e.keyCode == 32)
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
            else if (e.keyCode == 178)
            {
                StopVideo();
            }
            else if (e.keyCode == 176 || e.keyCode == 71)
            {
                NextVideo();
            }
            else if (e.keyCode == 177 || e.keyCode == 37 || e.keyCode == 70)
            {
                PreviousVideo();
            }
            else if (e.keyCode == 76 || e.keyCode == 39)
            {
                ShowVideoList();
            }
            //else
            //{
            //    MessageBox.Show("vlc KeyDownEvent" + "\n" + e.keyCode.ToString());
            //}
        }

        private void axVLCPlugin_MediaPlayerPlaying(object sender, EventArgs e)
        {
            playing = true;
            int i = axVLCPlugin.playlist.currentItem;

            try
            {
                if(string.IsNullOrEmpty(axVLCPlugin.mediaDescription.url))
                {
                    if (i == -1)
                    {
                        axVLCPlugin.playlist.playItem(z + 1);
                    }
                    else
                    {
                        z = axVLCPlugin.playlist.currentItem;
                    }
                    lblVideoBox.Text =string.Format("{0} {1}/{2}", videofiles[i], i + 1, videofiles.Count);
                    listBoxVideoList.SelectedIndex = axVLCPlugin.playlist.currentItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void axVLCPlugin_MediaPlayerPaused(object sender, EventArgs e)
        {
            playing = false;
        }

        private void axVLCPlugin_MediaPlayerStopped(object sender, EventArgs e)
        {
            playing = false;
        }

        private void axVLCPlugin_DblClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxVideoList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axVLCPlugin.playlist.playItem(listBoxVideoList.SelectedIndex);
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
            //else
            //{
            //    MessageBox.Show(e.KeyData.ToString());
            //}
        }

        private void listBoxVideoList_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardKeyDown(e);
        }

        private void lblVideoBox_Click(object sender, EventArgs e)
        {
            ShowVideoList();
        }
    }
}