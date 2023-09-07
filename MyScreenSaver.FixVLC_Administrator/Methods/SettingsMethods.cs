using System;
using System.IO;

namespace MyScreenSaver.FixVLC_Administrator.Methods
{
    internal class SettingsMethods
    {
        internal static bool IsDirExists(string dirPath)
        {
            try
            {
                return Directory.Exists(dirPath);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal static bool IsFileExists(string filePath)
        {
            try
            {
                return File.Exists(filePath);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
