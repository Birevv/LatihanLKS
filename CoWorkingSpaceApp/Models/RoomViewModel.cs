using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Models
{
    public class RoomViewModel
    {
        public int room_id { get; set; }
        public int space_id { get; set; }
        public string name { get; set; }
        public string type { get; set; }    
        public int price { get; set; }
        public int capacity { get; set; }   
        public string equipment { get; set; }

    }
}
