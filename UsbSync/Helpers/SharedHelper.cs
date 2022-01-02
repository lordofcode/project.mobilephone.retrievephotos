using PhoneConnector;
using PhoneConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbSync.Helpers
{
    public static class SharedHelper
    {
        public static bool HasImages(IPhoneFolder folder)
        {
            var validExtensions = Utils.GetImageExtensions(SettingsHelper.GetImageExtensions);
            foreach (var file in folder.Files)
            {
                var fileExtension = Path.GetExtension(file.Name).ToLower();
                if (validExtensions.Contains(fileExtension))
                {
                    return true;
                }
            }
            return false;
        }

        public static string new_temp_path()
        {
            var temp_dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";
            if (Directory.Exists(temp_dir + "Temp"))
                temp_dir += "Temp\\";
            temp_dir += "external_drive_temp\\temp-" + DateTime.Now.Ticks;

            Directory.CreateDirectory(temp_dir);
            return temp_dir;
        }
    }
}
