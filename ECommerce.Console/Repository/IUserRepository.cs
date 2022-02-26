using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository:IGenericCRUD<User>
    {
        bool IsPasswordMatch(string Password, string ConfirmPassword);
        User LogIn(string UserName, string Password);
        bool IsUserValidate(User entity,bool IsUpdate= false);
        bool IsUserNameExist(string UserName);
        bool IsExist(int Id);
        bool IsExist(string UserName,string Password);
    }
}
