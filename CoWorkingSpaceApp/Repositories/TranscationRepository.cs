using CoWorkingSpaceApp.Models;
using CoWorkingSpaceApp.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CoWorkingSpaceApp.Repositories
{
    public class TranscationRepository : BaseRepository<bookings>
    {
        public IEnumerable<dynamic> GetBookingHistory()
        {
            using (SqlConnection db = Helpers.DbConnection.GetConn())
            {
                {
                    string query = @"
                    SELECT 
                        b.booking_id,
                        u.name AS CustomerName,
                        s.name AS SpaceName,
                        b.start_time AS StartTime,
                        b.end_time AS EndTime,
                        b.status AS Status
                    FROM bookings b
                    INNER JOIN users u ON b.user_id = u.user_id
                    INNER JOIN spaces s ON b.space_id = s.space_id
                    ORDER BY b.start_time DESC";

                    return db.Query(query);
                }
            }
        }
    }
}





