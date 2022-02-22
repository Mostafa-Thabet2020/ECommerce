using ECommerce.Console.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Models
{
    public class Governrote:Audit
    {
        public string Name { get; set; }
        public List<City> cities { get; set; }
    }
}
