using ECommerce;
using ECommerce.Models;
using ECommerce.Repository;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
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
            if (IsOrderValid(entity) && !IsExist(entity))
            {

                entity.CreatedDate = DateTime.Now;
                entity.UserID = user.Id;
                
                dbContext.orders.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            if (IsExist(Get(Id)))
            {
                Order order = Get(Id);
                order.IsDelete = true;
                order.DeletedTime = DateTime.Now;
                dbContext.orders.Update(order);
                dbContext.SaveChanges();
            }
        }

        public Order Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.orders.Include(x => x.orderDetails).Include(x => x.user).SingleOrDefault(x => x.Id == id);
            }
            return null;
        }

        public List<Order> Get()
        {
            return dbContext.orders.Where(x => x.IsDelete == false).Include(x=>x.user).Include(x=>x.orderDetails).ToList();
        }

        public List<Order> GetByClient(int Id)
        {
            return dbContext.orders.Where(x => x.UserID == Id).ToList();
        }

        public int GetCount()
        {
            return dbContext.orders.Count();
        }

        public double GetTotal(int Id)
        {
            return dbContext.orders.ToList().Sum(x => x.Total);
        }

        public bool IsExist(Order entity)
        {
            return dbContext.orders.Any(x => x.Id == entity.Id && x.IsDelete == false);
        }

        public bool IsExistById(int Id)
        {
            return dbContext.orders.Any(x => x.Id == Id);
        }

        public bool IsOrderValid(Order entity)
        {
            if (entity.IsDelete == false
                && entity.UserID > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsShipped(int Id)
        {
            if (IsExistById(Id))
            {
                return dbContext.orders.Find(Id).IsShipped;
            }
            return false;
        }

        public void Shipped(int Id)
        {
            if (IsExistById(Id))
            {
                Order order = Get(Id);
                order.IsShipped=true;
                dbContext.orders.Update(order);
                dbContext.SaveChanges();
            }
        }

        public int ShippedCount()
        {
            return dbContext.orders.Where(x=>x.IsShipped==true && x.IsDelete == false).Count();
        }

        public double ShippedTotal()
        {
            return dbContext.orders.Where(x => x.IsShipped == true&& x.IsDelete==false).Sum(x => x.Total);
        }

        public List<Order> SortByTop()
        {
            return dbContext.orders.Where(x=>x.IsDelete==false).OrderBy(x=>x.Total).ToList();
        }

        public int UnShippedCount()
        {
            return dbContext.orders.Where(x=>x.IsDelete==false && x.IsShipped==false).Count();
        }

        public double UnShippedTotal()
        {
            return dbContext.orders.Where(x => x.IsShipped == false && x.IsDelete == false).Sum(x => x.Total);
        }

        public void Update(Order entity)
        {
            if (IsExist(entity))
            {
                Order newOrder = Get(entity.Id);
                newOrder.LastModifiedDate = DateTime.Now;
                newOrder.IsShipped = entity.IsShipped;
                newOrder.Total = entity.Total;
                newOrder.orderDetails = entity.orderDetails;
                dbContext.orders.Update(newOrder);
                dbContext.SaveChanges();
            }
        }
    }
}
