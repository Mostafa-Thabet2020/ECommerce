using ECommerce.Models;
using Parent;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User:Humen
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public UserRole userRole { get; set; }
        public List<Mobile> mobiles { get; set; }
        public List<Address> addresses { get; set; }
        public List<Order> orders { get; set; }
    }
}
