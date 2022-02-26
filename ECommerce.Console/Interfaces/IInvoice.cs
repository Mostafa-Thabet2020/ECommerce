using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Interfaces
{
    public interface IInvoice
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
    }
}
