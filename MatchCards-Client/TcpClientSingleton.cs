using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchCards_Client
{
    public static class TcpClientSingleton
    {
        public static SimpleTcpClient Client { get; set; }
    }
}
