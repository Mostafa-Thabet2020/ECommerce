using ECommerce.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository
{
    public interface IOrderRepository:IGenericCRUD<Order>,IValidation<Order>
    {
        bool IsOrderValid(Order entity);
        double GetTotal(int Id);
        int GetCount();
        void Shipped(int Id);
        bool IsShipped(int Id);
        int ShippedCount();
        int UnShippedCount();
        double ShippedTotal();
        double UnShippedTotal();
        List<Order> GetByClient(int Id);
        List<Order> SortByTop();

    }
}
