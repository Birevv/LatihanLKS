using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Models
{
    [Table("users")]
    public class users
    {
        [Key]
        public int user_id { get; set; }    
        public string name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string password { get; set; }
    }
}
