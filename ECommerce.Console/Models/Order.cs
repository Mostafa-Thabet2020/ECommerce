using Audits;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Order:FullAudit
    {
        public string Descripation { get; set; }
        [Required(ErrorMessage ="User id is required")]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User user { get; set; }
        public bool IsShipped { get; set; }=false;
        public double Total { get { return orderDetails.Where(x => x.orderId == Id).ToList().Sum(x => x.Total); } set { value = orderDetails.Where(x => x.orderId == Id).ToList().Sum(x => x.Total); } }
        public List<OrderDetails> orderDetails { get; set; }
    }
}
