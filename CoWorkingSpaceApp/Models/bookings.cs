using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace CoWorkingSpaceApp.Models
{
    [Table("bookings")]
    public class bookings
    {
        [Key]
        public int booking_id { get; set; }
        public int user_id { get; set; }
        public int space_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public string status { get; set; }  
    }
}
