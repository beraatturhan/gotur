using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;

namespace gotur
{
    public class Connection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        }
    }
}