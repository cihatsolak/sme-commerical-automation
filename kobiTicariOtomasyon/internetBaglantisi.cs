using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.InteropServices;

namespace kobiTicariOtomasyon
{
    class internetBaglantisi
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto)]
        static extern bool InternetGetConnectedState(ref ConnectionState IpdwFlags, int dwReserved);

        [Flags]
        enum ConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }
        ConnectionState Description = 0;

        public bool internet()
        {
            bool baglanti = InternetGetConnectedState(ref Description, 0);
            if (baglanti == true)
            {
                return true;
            }
            else
                return false;
        }
}
}
