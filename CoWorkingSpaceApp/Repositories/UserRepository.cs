using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using CoWorkingSpaceApp.Helpers;
using CoWorkingSpaceApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace CoWorkingSpaceApp.Repositories
{
    public class UserRepository : BaseRepository<users>
    {
        public users Login(string email, string password)
        {
            try
            {
                using (IDbConnection db = DbConnection.GetConn())
                {
                    string query = "SELECT * FROM users WHERE email = @Email AND password = @password";
                    return db.QueryFirstOrDefault<users>(query, new { Email = email, password = password });
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Terjadi Kesalahan pada database: "  + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Terjadi Kesalahan " + ex.Message);
            }
            
        }
    }
}