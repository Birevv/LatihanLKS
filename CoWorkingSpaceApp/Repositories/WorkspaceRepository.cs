using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoWorkingSpaceApp.Helpers;
using Dapper;
using CoWorkingSpaceApp.Models;
using System.Data.SqlClient;

namespace CoWorkingSpaceApp.Repositories
{
    public class WorkspaceRepository : BaseRepository<spaces>
    {
        public IEnumerable<spaces> GetByType(string roomType)
        { 
            using (SqlConnection db = DbConnection.GetConn())
            {
                string query = "SELECT * FROM spaces WHERE type = @type";
                return db.Query<spaces>(query, new {type = roomType});
            }
        }

        public IEnumerable<spaces> SearchByName(string keyword)
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                string query = "SELECT * FROM spaces WHERE name LIKE @Keyword";
                return db.Query<spaces>(query, new {Keyword = "%" + keyword + "%" });
            }
        }
        
    }
}
