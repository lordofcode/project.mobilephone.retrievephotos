using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConnector.Interfaces
{
    public interface IPhoneFile
    {
        string Name { get; }
        string Path { get; }
        DateTime LastWriteTime { get; }
        void CopyFile(string destination);
    }
}
