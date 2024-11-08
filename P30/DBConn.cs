using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30
{
    internal static class DBConn
    {
        public static string HostName { get; set; } = "(localdb)\\MSSQLLocalDB";
        public static string Login { get; set; } = "";
        public static string Password { get; set; } = "";
    }
}
