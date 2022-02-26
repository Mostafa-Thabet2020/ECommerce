using Audits;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Models
{
    public class Product:Audit
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double? Cost { get; set; }
        public double? Profit { get { return Price - Cost; } set { value = Price - Cost; } }
        public bool IsDisplay { get; set; }
        public DateTime ProductionDate { get; set; }
    }
}
