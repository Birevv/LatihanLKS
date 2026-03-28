using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using CoWorkingSpaceApp.Helpers;
using CoWorkingSpaceApp.Models;
using System.Data.SqlClient;

namespace CoWorkingSpaceApp.Repositories
{
    public class UserRepository : BaseRepository<users>
    {
        public users Login(string email, string password)
        {
            using (SqlConnection db = new SqlConnection())
            {
                string query = "SELECT * FROM users WHERE email = @Email AND password = @password AND role = 'admin'";
                return db.QueryFirstOrDefault<users>(query, new {Email = email, password = password});
            }
        }
    }
}
