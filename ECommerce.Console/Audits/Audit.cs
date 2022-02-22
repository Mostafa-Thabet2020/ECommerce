using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Console.Bases;
namespace ECommerce.Console.Audits
{
    public class Audit:Base
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }=DateTime.Now;
    }
}
