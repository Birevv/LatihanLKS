using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Models
{
    [Table("payments")]
    public class payments
    {
        [Key]
        public int payment_id { get; set;  }
        public int booking_id { get; set; } 
        public Decimal amount { get; set; }
        public string payment_method {get; set;}
        public DateTime payment_date { get; set; }
    }
}
