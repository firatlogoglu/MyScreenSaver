using MyScreenSaver.Languages;
using MyScreenSaver.Models.WMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace MyScreenSaver
{
    public partial class ShowScreenSaverForm : Form
    {
        private List<string> picturefiles = new List<string>();
        private List<string> musicfiles = new List<string>();

        private static List<string> picture_extensions = new List<string>();
        private static List<string> music_extensions = new List<string>();

        private bool pause = false;
        private int i = 0;
        private int z = 0;
        private int music_i = 0;
        private int music_z = 0;
        private int vlc_music_z = 0;
        private int tick;
        private int msplayerstatus;
        private bool msplayerstart;
        private bool playing;

        public ShowScreenSaverForm()
        {
            InitializeComponent();
            GetSettings();
        }

        private void ShowImageAndMusicLists()
        {
            if (panel1.Enabled == false)
            {
                panel1.Enabled = panel1.Visible = true;
            }
            else
            {
                panel1.Enabled = panel1.Visible = false;
            }
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
        private void ErrorImage(string error)
        {
            pictureBox.Image = Properties.Resources.Error;
            lblpictureBox.Text = string.Format("{0}: {1}", Localization.Error, error);
        }

        private void ErrorMusic()
        {
            pictureBox.Image = Properties.Resources.Error;
            lblmusicBox.Text = Localization.Error;
        }
        private void ErrorMusic(string error)
        {
            pictureBox.Image = Properties.Resources.Error;
            lblmusicBox.Text = string.Format("{0}: {1}", Localization.Error, error);
        }

        private void GetSettings()
        {
            this.Text = Localization.ImageSlideshow;
            lblTime.Visible = Properties.Settings.Default.ShowTime;

            try
            {
                foreach (var item in Properties.Settings.Default.PictureExtensions)
                {
                    picture_extensions.Add(item);
                }

                foreach (var item in Properties.Settings.Default.PictureDir)
                {
                    picturefiles.AddRange(SearchForPictureFiles(item));
                }

                z = picturefiles.Count();
                listBoxImageList.DataSource = picturefiles;
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
                ImageLocation(picturefiles[0]);
            }
            else
            {
                ErrorImage(Localization.ERROR_NoPicture);
            }

            if (Properties.Settings.Default.MusicPlayer)
            {
                lblmusicBox.Visible = true;
                try
                {
                    foreach (var item in Properties.Settings.Default.MusicExtensions)
                    {
                        music_extensions.Add(item);
                    }

                    foreach (var item in Properties.Settings.Default.MusicDir)
                    {
                        musicfiles.AddRange(SearchForMusicFiles(item));
                        music_z = musicfiles.Count();

                        if (!Properties.Settings.Default.MusicAppWMP)
                        {
                            string fi = "file:///";

                            try
                            {
                                foreach (var it in musicfiles)
                                {
                                    axVLCPlugin.playlist.add(fi + it);
                                }

                                if (Properties.Settings.Default.VLC_URL != null)
                                {
                                    foreach (var url in Properties.Settings.Default.VLC_URL)
                                    {
                                        musicfiles.Add(url);
                                        axVLCPlugin.playlist.add(url);
                                    }
                                }
                                axVLCPlugin.playlist.play();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                continue;
                            }
                        }
                    }

                    listBoxMusicList.DataSource = musicfiles;

                    if (Properties.Settings.Default.MusicAppWMP)
                    {
                        if (music_z != 0)
                        {
                            LblmusicBox_Text(musicfiles[0]);
                        }
                        else
                        {
                            ErrorMusic(Localization.ERROR_NoMusic);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                lblmusicBox.Visible = false;
                axWinMediaPlayer.close();
            }

            if (!Properties.Settings.Default.ClockAndDate)
            {
                timerClockAndDate.Enabled = false;
                lblClock.Visible = false;
                timerClockAndDate.Stop();
            }
            else
            {
                timerClockAndDate.Enabled = true;
                lblClock.Visible = true;
                timerClockAndDate.Start();
            }
        }

        static List<string> SearchForPictureFiles(string directory)
        {
            var pictureFiles = new List<string>();

            try
            {
                foreach (string ext in picture_extensions)
                {
                    foreach (string filePath in Directory.GetFiles(directory, ext))
                    {
                        pictureFiles.Add(filePath);
                    }
                }

                foreach (string subDirectory in Directory.GetDirectories(directory))
                {
                    try
                    {
                        pictureFiles.AddRange(SearchForPictureFiles(subDirectory));
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        // MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // MessageBox.Show(ex.Message);
            }

            return pictureFiles;
        }

        static List<string> SearchForMusicFiles(string directory)
        {
            var musicFiles = new List<string>();

            try
            {
                foreach (string ext in music_extensions)
                {
                    foreach (string filePath in Directory.GetFiles(directory, ext))
                    {
                        musicFiles.Add(filePath);
                    }
                }

                foreach (string subDirectory in Directory.GetDirectories(directory))
                {
                    try
                    {
                        musicFiles.AddRange(SearchForMusicFiles(subDirectory));
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

            return musicFiles;
        }

        private void PreviousPicture()
        {
            try
            {
                if (z != 0)
                {
                    ImageLocation(picturefiles[--i].ToString());
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
                        ImageLocation(picturefiles[i]);
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
                    ImageLocation(picturefiles[++i].ToString());
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
                        pictureBox.ImageLocation = picturefiles[i];
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
            if (!Properties.Settings.Default.ImageSlideshow)
            {
                Application.Restart();
            }
            listBoxImageList.DataSource = listBoxMusicList.DataSource = null;
            picturefiles.Clear();
            picture_extensions.Clear();
            musicfiles.Clear();
            music_extensions.Clear();
            i = 0;
            z = 0;
            music_i = 0;
            music_z = 0;
            vlc_music_z = 0;
            axVLCPlugin.playlist.stop();
            axVLCPlugin.playlist.items.clear();
            axWinMediaPlayer.close();
            GetSettings();
            PictureAuto();
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
            lblpictureBox.Text = string.Format("{0} {1}/{2}", pictureBox.ImageLocation, i + 1, picturefiles.Count);
            listBoxImageList.SelectedIndex = i;
            PictureAuto();
        }

        private void ShowScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardKeyDown(e);
        }

        private void NextMusic()
        {
            try
            {
                if (music_z != 0)
                {
                    LblmusicBox_Text(musicfiles[++music_i]);
                }
                else
                {
                    ErrorMusic();
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233086)
                {
                    if (music_z != 0)
                    {
                        music_i = 0;
                        LblmusicBox_Text(musicfiles[music_i]);
                    }
                    else
                    {
                        ErrorMusic();
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PreviousMusic()
        {
            try
            {
                if (music_z != 0)
                {
                    LblmusicBox_Text(musicfiles[--music_i]);
                }
                else
                {
                    ErrorMusic();
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233086)
                {
                    music_i = music_z - 1;
                    if (music_z != 0)
                    {
                        LblmusicBox_Text(musicfiles[music_i]);
                    }
                    else
                    {
                        ErrorMusic();
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LblmusicBox_Text(string part)
        {
            try
            {
                lblmusicBox.Text = string.Format("{0} {1}/{2}", part, music_i + 1, musicfiles.Count);
                if (Properties.Settings.Default.MusicAppWMP)
                {
                    axWinMediaPlayer.URL = part;
                    listBoxMusicList.SelectedIndex = music_i;
                    axWinMediaPlayer.Ctlcontrols.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MusicPlayer)
            {
                if (Properties.Settings.Default.MusicAppWMP)
                {
                    if (msplayerstatus == (int)PlayStates.Ready)
                    {
                        axWinMediaPlayer.Ctlcontrols.play();
                    }
                }
                else
                {
                    axVLCPlugin.playlist.play();
                }
                timer2.Stop();
            }
        }

        private void axWinMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Properties.Settings.Default.MusicPlayer)
            {
                msplayerstatus = e.newState;
                if (e.newState == ((int)PlayStates.MediaEnded) /*|| e.newState == 1*/)
                {
                    timer2.Start();
                    NextMusic();
                }
            }
        }
        int sd = 1;


        private void timerClockAndDate_Tick(object sender, EventArgs e)
        {

            sd++;

            lblClock.Text = DateTime.Now.ToString();
            //MessageBox.Show(panel1.Location.X + "\n" + panel1.Location.Y);
            Random rd = new Random();

            if (sd == 50)
            {
                lblClock.Location = new Point(rd.Next(1, 1200), rd.Next(1, 1200));
                sd = 1;
            }
        }

        private void KeyboardKeyDown(KeyEventArgs e)
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
            else if (e.KeyData == Keys.MediaPlayPause && Properties.Settings.Default.MusicPlayer)
            {
                if (Properties.Settings.Default.MusicAppWMP)
                {
                    if (msplayerstart)
                    {
                        axWinMediaPlayer.Ctlcontrols.pause();
                        msplayerstart = false;
                    }
                    else
                    {
                        axWinMediaPlayer.Ctlcontrols.play();
                        msplayerstart = true;
                    }
                }
                else
                {
                    if (playing)
                    {
                        axVLCPlugin.playlist.pause();
                    }
                    else
                    {
                        axVLCPlugin.playlist.play();
                    }
                }

            }
            else if (e.KeyData == Keys.MediaStop && Properties.Settings.Default.MusicPlayer)
            {
                if (Properties.Settings.Default.MusicAppWMP)
                {
                    axWinMediaPlayer.Ctlcontrols.stop();
                }
                else
                {
                    axVLCPlugin.playlist.stop();
                }

            }
            else if (e.KeyData == Keys.MediaNextTrack && Properties.Settings.Default.MusicPlayer)
            {
                if (Properties.Settings.Default.MusicAppWMP)
                {
                    NextMusic();
                }
                else
                {
                    axVLCPlugin.playlist.next();
                }

            }
            else if (e.KeyData == Keys.MediaPreviousTrack && Properties.Settings.Default.MusicPlayer)
            {
                if (Properties.Settings.Default.MusicAppWMP)
                {
                    PreviousMusic();
                }
                else
                {
                    axVLCPlugin.playlist.prev();
                }
            }
            else if (e.KeyData == Keys.L)
            {
                ShowImageAndMusicLists();
            }
        }

        private void listBoxImageList_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardKeyDown(e);
        }

        private void listBoxMusicList_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardKeyDown(e);
        }

        private void listBoxImageList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (z != 0)
            {
                i = listBoxImageList.SelectedIndex - 1;
                NextPicture();
            }
            else
            {
                ErrorImage(Localization.ERROR_NoPicture);
            }
        }

        private void listBoxMusicList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.MusicAppWMP)
            {
                if (music_z != 0)
                {
                    music_i = listBoxMusicList.SelectedIndex - 1;
                    NextMusic();
                }
                else
                {
                    ErrorMusic();
                }
            }
            else
            {
                axVLCPlugin.playlist.playItem(listBoxMusicList.SelectedIndex);
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

        private void axVLCPlugin_MediaPlayerPlaying(object sender, EventArgs e)
        {
            playing = true;
            music_i = axVLCPlugin.playlist.currentItem;

            try
            {
                if(string.IsNullOrEmpty(axVLCPlugin.mediaDescription.url))
                {
                    if (music_i == -1)
                    {
                        axVLCPlugin.playlist.playItem(vlc_music_z + 1);
                    }
                    else
                    {
                        vlc_music_z = axVLCPlugin.playlist.currentItem;
                    }
                    lblmusicBox.Text = string.Format("{0} {1}/{2}", musicfiles[music_i], music_i + 1, musicfiles.Count);
                    listBoxMusicList.SelectedIndex = axVLCPlugin.playlist.currentItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}