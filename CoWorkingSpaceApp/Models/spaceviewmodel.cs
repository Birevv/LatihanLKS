using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Models
{
    public class spaceviewmodel
    {
        public int space_id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int capacity { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
    }
}
