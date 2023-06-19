using MyScreenSaver.Properties;
using System.Globalization;
using System.Windows.Forms;

namespace MyScreenSaver.Methods
{
    internal class SettingsMethods
    {
        internal static void SetAppCloseMouseDbClick(bool mouseDbClick)
        {
            if (mouseDbClick)
            {
                Settings.Default.AppCloseMouseDbClick = true;
            }
            else
            {
                Settings.Default.AppCloseMouseDbClick = false;
            }
            Settings.Default.Save();
        }

        internal static void SetPictureAuto(bool chk)
        {
            if (chk)
            {
                Settings.Default.PictureAuto = true;
            }
            else
            {
                Settings.Default.PictureAuto = false;
            }
            Settings.Default.Save();
        }

        internal static void ChkBoxShowTime(bool chk)
        {
            if (chk)
            {
                Settings.Default.ShowTime = true;
            }
            else
            {
                Settings.Default.ShowTime = false;
            }
            Settings.Default.Save();
        }

        internal static void SetRememberRemoveFileList(bool chk)
        {
            if (chk)
            {
                Settings.Default.RememberRemoveFileList = true;
            }
            else
            {
                Settings.Default.RememberRemoveFileList = false;
            }
            Settings.Default.Save();
        }

        internal static void RadioBtnImageSlideshow(bool chk)
        {
            if (chk)
            {
                Settings.Default.ImageSlideshow = true;
            }
            else
            {
                Settings.Default.ImageSlideshow = false;
            }
            Settings.Default.Save();
        }

        internal static void RadioBtnWPA(bool chk)
        {
            if (chk)
            {
                Settings.Default.VideoAppWMP = true;
            }
            else
            {
                Settings.Default.VideoAppWMP = false;
            }
            Settings.Default.Save();
        }

        internal static void SetLanguage(string languageName, string languageCode)
        {
            Localization.Culture = new CultureInfo(languageCode);
            Settings.Default.Language = languageName;
            Settings.Default.Save();
            Application.Restart();
        }

        internal static void AddPictureDirs(string selectedpath)
        {
            Settings.Default.PictureDir.Add(selectedpath);
            Settings.Default.Save();
        }

        internal static void RemovePictureDir(int index)
        {
            Settings.Default.PictureDir.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void DefaultPictureDirs(string defaultuser)
        {
            Settings.Default.PictureDir.Clear();
            Settings.Default.PictureDir.Add(defaultuser);
            Settings.Default.Save();
        }

        internal static void AllRemovePictureDirs()
        {
            Settings.Default.PictureDir.Clear();
            Settings.Default.Save();
        }

        internal static void SetTimePicture(int time)
        {
            Settings.Default.PictureTime = time;
            Settings.Default.Save();
        }

        internal static void AddMusicDirs(string selectedpath)
        {
            Settings.Default.MusicDir.Add(selectedpath);
            Settings.Default.Save();
        }

        internal static void RemoveMusicDir(int index)
        {
            Settings.Default.MusicDir.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemoveMusicDirs()
        {
            Settings.Default.MusicDir.Clear();
            Settings.Default.Save();
        }

        internal static void AddPictureExtension(string extension)
        {
            Settings.Default.PictureExtensions.Add(extension);
            Settings.Default.Save();
        }

        internal static void DefaultPictureExtension(string[] extension)
        {
            Settings.Default.PictureExtensions.Clear();
            Settings.Default.PictureExtensions.AddRange(extension);
            Settings.Default.Save();
        }

        internal static void RemovePictureExtension(int index)
        {
            Settings.Default.PictureExtensions.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemovePictureExtensions()
        {
            Settings.Default.PictureExtensions.Clear();
            Settings.Default.Save();
        }

        internal static void ChkBoxMusicPlayer(bool chk)
        {
            if (chk)
            {
                Settings.Default.MusicPlayer = true;
            }
            else
            {
                Settings.Default.MusicPlayer = false;
            }
            Settings.Default.Save();
        }

        internal static void DefaultMusicDirs(string defaultuser)
        {
            Settings.Default.MusicDir.Clear();
            Settings.Default.MusicDir.Add(defaultuser);
            Settings.Default.Save();
        }

        internal static void AddMusicExtension(string extension)
        {
            Settings.Default.MusicExtensions.Add(extension);
            Settings.Default.Save();
        }

        internal static void DefaultMusicExtension(string[] extension)
        {
            Settings.Default.MusicExtensions.Clear();
            Settings.Default.MusicExtensions.AddRange(extension);
            Settings.Default.Save();
        }

        internal static void RemoveMusicExtension(int index)
        {
            Settings.Default.MusicExtensions.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemoveMusicExtensions()
        {
            Settings.Default.MusicExtensions.Clear();
            Settings.Default.Save();
        }

        internal static void AddVideoDirs(string selectedpath)
        {
            Settings.Default.VideoDir.Add(selectedpath);
            Settings.Default.Save();
        }

        internal static void RemoveVideoDir(int index)
        {
            Settings.Default.VideoDir.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemoveVideoDirs()
        {
            Settings.Default.VideoDir.Clear();
            Settings.Default.Save();
        }

        internal static void DefaultVideoDirs(string defaultuser)
        {
            Settings.Default.VideoDir.Clear();
            Settings.Default.VideoDir.Add(defaultuser);
            Settings.Default.Save();
        }

        internal static void AddVideoExtension(string extension)
        {
            Settings.Default.VideoExtensions.Add(extension);
            Settings.Default.Save();
        }

        internal static void DefaultVideoExtension(string[] extension)
        {
            Settings.Default.VideoExtensions.Clear();
            Settings.Default.VideoExtensions.AddRange(extension);
            Settings.Default.Save();
        }

        internal static void RemoveVideoExtension(int index)
        {
            Settings.Default.VideoExtensions.RemoveAt(index);
            Settings.Default.Save();
        }

        internal static void AllRemoveVideoExtensions()
        {
            Settings.Default.VideoExtensions.Clear();
            Settings.Default.Save();
        }

        internal static bool FullPictureDir()
        {
            if (Settings.Default.PictureDir.Count > 0 && Settings.Default.PictureExtensions.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool FullVideoDir()
        {
            if (Settings.Default.VideoDir.Count > 0 && Settings.Default.VideoExtensions.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static void SetClockAndDate(bool chk)
        {
            if (chk)
            {
                Settings.Default.ClockAndDate = true;
            }
            else
            {
                Settings.Default.ClockAndDate = false;
            }
            Settings.Default.Save();
        }
    }
}