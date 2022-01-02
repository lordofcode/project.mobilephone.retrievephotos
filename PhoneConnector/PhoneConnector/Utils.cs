using external_drive_lib.interfaces;
using PhoneConnector.Interfaces;
using PhoneConnector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConnector
{
    public static class Utils
    {
        /// <summary>
        /// Enable configuration by app-settings to define which extensions are valid image-extensions
        /// PRE: comma-seperated string with items e.g. .bmp,.jpg,.png
        /// </summary>
        /// <param name="imageExtensions"></param>
        /// <returns></returns>
        public static List<string> GetImageExtensions(string imageExtensions)
        {
            var result = new List<string>();
            var items = imageExtensions.Split(new char[] { ',' });
            foreach (var item in items)
            {
                var trimmedItem = item.Trim().ToLower();
                if (string.IsNullOrEmpty(trimmedItem))
                {
                    continue;
                }
                if (result.Contains(trimmedItem))
                {
                    continue;
                }
                result.Add(trimmedItem);
            }
            return result;
        }

        public static IPhoneFolder GetFolderByPath(string path)
        {
            try
            {
                return new PhoneFolder(external_drive_lib.drive_root.inst.try_parse_folder(path));
            }
            catch (Exception) { return null; }
        }

        public static IPhoneFile GetFileByPath(string path)
        {
            var result = external_drive_lib.drive_root.inst.try_parse_file(path);
            if (result == null) return null;
            return new PhoneFile(result);
        }

        public static void CopyFile(IPhoneFile file, string location)
        {
            file.CopyFile(location);
        }
    }
}
