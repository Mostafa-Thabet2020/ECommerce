using ECommerce;
using ECommerce.Models;
using ECommerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class ProductService : IProductRepository
    {
        EcommorceDbContext dbContext = new EcommorceDbContext();

        public void Active(int id)
        {
            if (IsExistById(id))
            {
                Product product = Get(id);
                product.IsDisplay=true;
                dbContext.products.Update(product);
                dbContext.SaveChanges();
            }
        }

        public void Add(Product entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                dbContext.products.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Dective(int id)
        {
            if (IsExistById(id))
            {
                Product product = Get(id);
                product.IsDisplay = false;
                dbContext.products.Update(product);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                Product product = Get(Id);
                dbContext.products.Remove(product);
            }
        }

        public Product Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.products.Find(id);
            }
            return null;
        }

        public List<Product> Get()
        {
            return dbContext.products.Where(x => x.IsDisplay == true).ToList();
        }

        public List<Product> GetAll()
        {
            return dbContext.products.ToList();
        }

        public bool IsExist(Product entity)
        {
            return dbContext.products.Any(x=>x.Id==entity.Id||x.ProductName==entity.ProductName);
        }

        public bool IsExistById(int Id)
        {
            return dbContext.products.Any(x => x.Id == Id);
        }

        public bool IsProductValid(Product entity)
        {
            if (!string.IsNullOrEmpty(entity.ProductName)
                && entity.Price>0
                && entity.Cost>0
                && !IsExist(entity))
            {
                return true;
            }
            return false;
        }

        public void Update(Product entity)
        {
            if (IsExistById(entity.Id))
            {
                Product product = Get(entity.Id);
                product.LastModifiedDate = DateTime.Now;
                product.ProductName=entity.ProductName;
                product.Cost = entity.Cost;
                product.Price = entity.Price;
                product.ProductionDate = entity.ProductionDate;
                dbContext.products.Update(product);
                dbContext.SaveChanges();
            }
        }
    }
}
