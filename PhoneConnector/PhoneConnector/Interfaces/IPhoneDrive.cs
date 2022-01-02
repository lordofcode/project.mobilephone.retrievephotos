using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConnector.Interfaces
{
    public interface IPhoneDrive
    {
        string Id { get; }
        string DisplayName { get; }
        string Type { get; }
        IEnumerable<IPhoneFolder> Folders { get; }
    }
}
