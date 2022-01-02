using external_drive_lib.interfaces;
using PhoneConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConnector.Models
{
    /// <summary>
    /// Holder for the folder, ignore all childfolders
    /// </summary>
    public class PhoneFolder : IPhoneFolder
    {
        public PhoneFolder(IFolder baseFolder)
        {
            Folder = baseFolder;
        }
        internal IFolder Folder { get; set; }

        public string Name => Folder.name;

        public string Path => Folder.full_path;

        public IEnumerable<IPhoneFolder> Folders { 
            get 
            {
                var result = new List<IPhoneFolder>();
                foreach (var child in Folder.child_folders)
                {
                    result.Add(new PhoneFolder(child));
                }
                return result;
            } 
        }

        public IEnumerable<IPhoneFile> Files
        {
            get
            {
                var result = new List<IPhoneFile>();
                foreach (var file in Folder.files)
                {
                    result.Add(new PhoneFile(file));
                }
                return result;
            }
        }
    }
}
