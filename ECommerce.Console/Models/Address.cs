using Audits;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Address:Audit
    {
        public int UserId { get; set; }
        public int CitiyId { get; set; }
        public string BuildingNumber { get; set; }
        public string FloorNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string AddressDetails { get; set; }
        [ForeignKey("CitiyId")]
        public City city { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }
    }
}
