using System;
using System.Collections.Generic;
using System.Text;

namespace ITGigsDB.Helpers
{
    public static class Constants
    {
        public static string GetAzureConnection()
        {
            return @"Server=tcp:p-fake-server.database.windows.net,1433;Initial 
            Catalog = p-fake-db; Persist Security Info = False;
            User ID = p-fake-admin;
            Password = Bethe12me;
            MultipleActiveResultSets = False;
            Encrypt = True;
            TrustServerCertificate = False;
            Connection Timeout = 30;";
        }
        public static string GetAppHarbourConnection()
        {
            return "";
        }
    }
}
