using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Repository
{
    public interface IValidation<T> where T : class
    {
        bool IsExist(T entity);
        bool IsExistById(int Id);
    }
}
