using external_drive_lib.interfaces;
using PhoneConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConnector.Models
{
    public class PhoneFile : IPhoneFile
    {
        public PhoneFile(IFile file)
        {
            File = file;
        }

        private IFile File { get; set; }
        public string Name => File.name;
        public string Path => File.full_path;
        public DateTime LastWriteTime => File.last_write_time;
        public void CopyFile(string destination)
        {
            File.copy_sync(destination);
        }
    }
}
