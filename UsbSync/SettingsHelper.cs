using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbSync
{
    public static class SettingsHelper
    {
        public static string GetPreferredPhone
        {
            get
            {
                try { return ConfigurationManager.AppSettings["preset_phone"]; }
                catch (Exception) { return ""; }
            }
        }

        public static bool DebugMode
        {
            get 
            {
                try { return bool.Parse(ConfigurationManager.AppSettings["debugmode"]); }
                catch (Exception) { return false; }
            }
        }

        public static string MobilePhotoPath
        {
            get
            {
                try { return ConfigurationManager.AppSettings["mobile_photo"]; }
                catch (Exception) { return ""; }
            }
        }

        public static string WhatsappPath
        {
            get
            {
                try { return ConfigurationManager.AppSettings["mobile_whatsapp"]; }
                catch (Exception) { return ""; }
            }
        }

        public static string GetSavePath
        {
            get
            {
                try { return ConfigurationManager.AppSettings["savelocation"]; }
                catch (Exception) { return ""; }
            }
        }

        public static string GetIgnoreTypes
        {
            get
            {
                try { return ConfigurationManager.AppSettings["ignoretypes"]; }
                catch (Exception) { return ""; }
            }
        }

        public static string GetImageExtensions
        {
            get
            {
                try { return ConfigurationManager.AppSettings["imageextensions"]; }
                catch (Exception) { return ""; }
            }
        }

        public static string PreviewUrl
        {
            get
            {
                try { return ConfigurationManager.AppSettings["preview_url"]; }
                catch (Exception) { return ""; }
            }
        }
    }
}
