using Audits;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Models
{
    public class Order:Audit
    {
        public string Descripation { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User user { get; set; }
        public double Total { get { return orderDetails.Where(x => x.orderId == Id).ToList().Sum(x => x.Total); } set { value = orderDetails.Where(x => x.orderId == Id).ToList().Sum(x => x.Total); } }
        public List<OrderDetails> orderDetails { get; set; }
    }
}
