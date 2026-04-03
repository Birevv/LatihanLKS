using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Helpers
{
    public static class DbConnection
    {
        private static string connectionString = @"Server=DESKTOP-DV8SGV8\SQLEXPRESS;Initial Catalog=CoWorkingSpaceAppDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public static SqlConnection GetConn()
        {
            return new SqlConnection(connectionString);
        }

    }
}
