using Audits;
using Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Mobile:Audit
    {
        public int UserId { get; set; }
        public string MobileNumber { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }
    }
}
