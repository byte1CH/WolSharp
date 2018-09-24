using System.Net.NetworkInformation;

namespace Byte1.WolSharp
{
    public interface IPhysicalAddressParser
    {
        bool TryParse(string s, out PhysicalAddress result);
        PhysicalAddress Parse(string macAddress);
    }
}
