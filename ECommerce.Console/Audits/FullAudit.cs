using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Audits
{
    public class FullAudit:Audit
    {
        public DateTime DeletedTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
