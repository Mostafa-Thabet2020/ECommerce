using ECommerce.Console.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Models
{
    public class User:Humen
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Mobile> mobiles { get; set; }
        public List<Address> addresses { get; set; }
    }
}
