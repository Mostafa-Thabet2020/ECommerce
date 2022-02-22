using ECommerce.Console.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Models
{
    public class City:Audit
    {
        public string Name { get; set; }
        public Governrote governrote { get; set; }
        public List<Address> addresses { get; set; }
    }
}
