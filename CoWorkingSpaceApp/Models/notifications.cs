using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Models
{
    [Table("notifications")]
    public class notifications
    {
        [Key]
        public int notification_id { get; set; }
        public int user_id {  get; set; }
        public string message { get; set; } 
        public string notification_type { get; set; }   
        public DateTime sent_time { get; set; } 
    }
}
