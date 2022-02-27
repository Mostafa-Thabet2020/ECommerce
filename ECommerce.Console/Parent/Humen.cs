using Audits;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parent
{
    public abstract class Humen:Audit
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Address> addresses { get; set; }
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

    }
}
