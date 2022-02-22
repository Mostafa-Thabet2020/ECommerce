using ECommerce.Console.Audits;
using ECommerce.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Parent
{
    public abstract class Humen:Audit
    {
        public Humen()//ctor
        {
            FullName=$"{FirstName} {LastName}";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Address> addresses { get; set; }
        public string FullName;
        
    }
}
