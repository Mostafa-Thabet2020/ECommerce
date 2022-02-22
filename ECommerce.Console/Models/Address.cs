using ECommerce.Console.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Models
{
    public class Address:Audit
    {
        public string BuildingNumber { get; set; }
        public string FloorNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string AddressDetails { get; set; }
        public City city { get; set; }
        public User user { get; set; }
    }
}
