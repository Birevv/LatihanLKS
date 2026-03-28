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
        private static string connectionString = @"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;";

        public static SqlConnection GetConn()
        {
            return new SqlConnection(connectionString);
        }

    }
}
