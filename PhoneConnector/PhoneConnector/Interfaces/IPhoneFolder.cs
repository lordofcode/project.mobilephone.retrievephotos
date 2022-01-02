using external_drive_lib.interfaces;
using PhoneConnector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConnector.Interfaces
{
    public interface IPhoneFolder
    {
        string Name { get; }
        string Path { get; }
        IEnumerable<IPhoneFolder> Folders { get; }
        IEnumerable<IPhoneFile> Files { get; }
    }
}
