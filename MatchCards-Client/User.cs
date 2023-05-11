using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchCards_Client
{
    public static class User
    {
        public static string IpPort { get; set; }
        public static string Username { get; set; }
        public static string OpponentIpPort { get; set; }
        public static string OpponentUserName { get; set; }
        public static string OpponentPairs { get; set; }
        public static int Points { get; set; }
    }
}
