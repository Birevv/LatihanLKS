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

        public IEnumerable<SpaceViewModel> GetAllSpaces()
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                string query = @"
            SELECT 
                s.space_id, 
                s.name, 
                s.location, 
                s.capacity, 
                s.type, 
                p.amount AS amount
            FROM spaces s
            LEFT JOIN bookings b ON s.space_id = b.space_id
            LEFT JOIN payments p ON b.booking_id = p.booking_id";
                return db.Query<SpaceViewModel>(query);
            }
        }

        public IEnumerable<chartdatamodel> GetStatisticsData()
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                string query = @"
            SELECT 
                    CONVERT(VARCHAR(10), b.start_time, 120) AS LabelX, 
                    COUNT(b.booking_id) AS TotalBooking,
                    ISNULL(SUM(p.amount), 0) AS Revenue,
                    COUNT(DISTINCT b.user_id) AS TotalCustomer
                FROM bookings b
                LEFT JOIN payments p ON b.booking_id = p.booking_id
                GROUP BY CONVERT(VARCHAR(10), b.start_time, 120)
                ORDER BY LabelX ASC";
                return db.Query<chartdatamodel>(query);
            }
        }

        public int GetTotalUsers()
        {
            {
                using (SqlConnection db = DbConnection.GetConn())
                {
                    string query = "SELECT COUNT(*) FROM users";
                    return db.ExecuteScalar<int>(query);
                }
            }
        }

        public int GetTotalRooms()
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                string query = "SELECT COUNT(*) FROM spaces";
                return db.ExecuteScalar<int>(query);
            }
        }

        public IEnumerable<RoomViewModel> GetAllRooms()
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                string query = @"
            SELECT 
                r.room_id AS room_id,
                r.space_id AS space_id,
                s.name       AS name,
                s.type       AS type,
                s.capacity   AS capacity,
                r.equipment  AS equipment,
                s.price      AS price
            FROM rooms r
            INNER JOIN spaces s ON r.space_id = s.space_id";
                return db.Query<RoomViewModel>(query);
            }
        }
        
    }
}
