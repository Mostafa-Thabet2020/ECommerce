using Audits;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class City:Audit
    {
        public string Name { get; set; }
        public int GovernroteId { get; set; }
        [ForeignKey("GovernroteId")]
        public Governrote governrote { get; set; }
        public List<Address> addresses { get; set; }
    }
}
