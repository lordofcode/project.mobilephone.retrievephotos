using external_drive_lib;
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
    public static class Connector
    {
        private static List<string> _ignoreDriveTypes { get; set; }

        /// <summary>
        /// set the types you want to ignore (if you only want to show the connected mobile phone(s))
        /// PRE: comma-seperated string with items e.g. internal_hdd,cd_rom
        /// </summary>
        /// <param name="ignoreTypes"></param>
        public static void SetIgnoreDriveTypes(string ignoreTypes)
        {
            _ignoreDriveTypes = new List<string>();
            var ignoreItems = ignoreTypes.Split(new char[] { ',' });
            foreach (var item in ignoreItems)
            {
                var trimmedItem = item.Trim().ToLower();
                if (string.IsNullOrEmpty(trimmedItem))
                {
                    continue;
                }
                if (_ignoreDriveTypes.Contains(trimmedItem))
                {
                    continue;
                }
                _ignoreDriveTypes.Add(trimmedItem);
            }
        }

        /// <summary>
        /// return true if we want to ignore this drive (eg. the C-drive)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsIgnoredDriveType(string type)
        {
            return _ignoreDriveTypes.Contains(type.ToLower());
        }

        /// <summary>
        /// Return list of all connected devices
        /// </summary>
        /// <returns></returns>
        public static List<IPhoneDrive> GetPhoneList()
        {
            var result = new List<IPhoneDrive>();
            try
            {
                foreach (var pd in drive_root.inst.drives)
                {
                    if (pd.is_available() && !IsIgnoredDriveType(pd.type.ToString()))
                    {
                        result.Add(new PhoneDrive(pd));
                    }
                }
                return result;
            }
            catch (Exception) { return new List<IPhoneDrive>(); }
        }

    }
}
