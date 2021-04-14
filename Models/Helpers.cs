using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
namespace justTesting.Models
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;
            string dbname = appConfig["aa196xwma502gkn"];
            if (string.IsNullOrEmpty(dbname)) return null;
            string username = appConfig["group17"];
            string password = appConfig["group17isveryawesomeindeed"];
            string hostname = appConfig["aa196xwma502gkn.cksmrsfasykk.us-east-1.rds.amazonaws.com"];
            string port = appConfig["1433"];
            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}