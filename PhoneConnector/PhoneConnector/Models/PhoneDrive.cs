using external_drive_lib.interfaces;
using PhoneConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConnector.Models
{
    public class PhoneDrive : IPhoneDrive
    {
        private IDrive _drive { get; set; }

        public PhoneDrive(IDrive drive)
        {
            _drive = drive;
        }

        public string Id => _drive.unique_id;
        public string Type => _drive.type.ToString();

        public string DisplayName => _drive.friendly_name;
        public IEnumerable<IPhoneFolder> Folders { 
            get{
                var result = new List<IPhoneFolder>();
                foreach (var f in _drive.folders)
                {
                    result.Add(new PhoneFolder(f));
                }
                return result;
            }
        }
        
    }
}
