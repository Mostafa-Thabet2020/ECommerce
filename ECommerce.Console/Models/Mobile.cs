using ECommerce.Console.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Models
{
    public class Mobile:Base
    {
        public string MobileNumber { get; set; }
        public User user { get; set; }
    }
}
