using ECommerce.Console.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Repository
{
    public interface IUserRoleRepository:IGenericCRUD<UserRole>,IValidation<UserRole>
    {
    }
}
