using ECommerce.Console.Models;
using ECommerce.Console.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console.Services
{
    public class OrderService : IOrderRepository
    {
        private readonly User user;
        EcommorceDbContext dbContext = new EcommorceDbContext();
        public OrderService(User User)
        {
            user = User;
        }
        public void Add(Order entity)
        {
            if (IsORderValid(entity))
            {
                entity.CreatedDate = DateTime.Now;
                entity.UserID = user.Id;
                dbContext.orders.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> Get()
        {
            throw new NotImplementedException();
        }

        public bool IsORderValid(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
