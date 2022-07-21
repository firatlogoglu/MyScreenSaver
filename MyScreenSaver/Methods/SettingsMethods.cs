using MyScreenSaver.Properties;
using System.Globalization;
using System.Windows.Forms;

namespace MyScreenSaver.Methods
{
    public class SettingsMethods
    {
        public static void SetAppCloseMouseDbClick(bool mouseDbClick)
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

        public static void ChkBoxPictureAuto(bool chk)
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

        public static void ChkBoxShowTime(bool chk)
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

        public static void SetLanguage(string languageName, string languageCode)
        {
            Localization.Culture = new CultureInfo(languageCode);
            Settings.Default.Language = languageName;
            Settings.Default.Save();
            Application.Restart();
        }

        public static void AddPictureDirs(string selectedpath)
        {
            Settings.Default.PictureDir.Add(selectedpath);
            Settings.Default.Save();
        }

        public static void RemovePictureDir(int index)
        {
            Settings.Default.PictureDir.RemoveAt(index);
            Settings.Default.Save();
        }

        public static void DefaultPictureDirs(string defaultuser)
        {
            Settings.Default.PictureDir.Clear();
            Settings.Default.PictureDir.Add(defaultuser);
            Settings.Default.Save();
        }

        public static void AllRemovePictureDirs()
        {
            Settings.Default.PictureDir.Clear();
            Settings.Default.Save();
        }

        public static void SetTimePicture(int time)
        {
            Settings.Default.PictureTime = time;
            Settings.Default.Save();
        }

        public static void AddPictureExtension(string extension)
        {
            Settings.Default.PictureExtensions.Add(extension);
            Settings.Default.Save();
        }

        public static void DefaultPictureExtension(string[] extension)
        {
            Settings.Default.PictureExtensions.Clear();
            Settings.Default.PictureExtensions.AddRange(extension);
            Settings.Default.Save();
        }

        public static void RemovePictureExtension(int index)
        {
            Settings.Default.PictureExtensions.RemoveAt(index);
            Settings.Default.Save();
        }

        public static void AllRemovePictureExtensions()
        {
            Settings.Default.PictureExtensions.Clear();
            Settings.Default.Save();
        }
    }
}