using System.Linq;
using System.Net.NetworkInformation;

namespace Custom
{
    public static class SystemProperties
    {
        public static string MAC_Address
        {
            get
            {
                return (from nic in NetworkInterface.GetAllNetworkInterfaces()
                        where nic.OperationalStatus == OperationalStatus.Up
                        select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
            }
        }
    }
}
