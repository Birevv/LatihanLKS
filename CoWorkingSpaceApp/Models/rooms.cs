using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Models
{
    [Table("rooms")]
    public class rooms
    {
        [Key]
        public int room_id {  get; set; }
        public int space_id { get; set; }   
        public string equipment { get; set; }
    }
}
