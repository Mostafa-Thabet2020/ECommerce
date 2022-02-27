using Audits;
using ECommerce.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Models
{
    public class OrderDetails:Audit,IInvoice
    {
        public int orderId { get; set; }
        public int productId { get; set; }

        [ForeignKey("orderId")]
        public Order order { get; set; }
        [ForeignKey("productId")]
        public Product product { get; set; }
        public int Quantity { get ; set ; }
        [NotMapped]
        public double Price { get { return product.Price; } set { value = product.Price ; } }
        [NotMapped]
        public double Total { get { return (Quantity * Price); } set { value = (Quantity * Price); } }
    }
}
