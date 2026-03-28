using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Models
{
    [Table("spaces")]
    public class spaces
    {
        [Key]
        public int space_id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int capacity { get; set; }
        public string type  { get; set; }   
    }
}
