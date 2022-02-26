using ECommerce.Console.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Repository
{
    public interface IProductRepository:IGenericCRUD<Product>,IValidation<Product>
    {
        void Active(int id);
        void Dective(int id);
        List<Product> GetAll();
        bool IsProductValid(Product entity);
    }
}
