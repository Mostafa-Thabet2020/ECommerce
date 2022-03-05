using ECommerce;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CityService : IGenericCRUD<City>,IValidation<City>
    {
        EcommorceDbContext dbContext = new EcommorceDbContext();
        public void Add(City entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                dbContext.cities.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                dbContext.cities.Remove(Get(Id));
                dbContext.SaveChanges();
            }
        }

        public City Get(int id)
        {
            if (IsExistById(id))
            {
             return dbContext.cities.Where(x => x.Id == id).SingleOrDefault();//SingleOrDefault for unique prop
            }
            return null;
        }

        public List<City> Get()
        {
            return dbContext.cities.ToList();
        }

        public bool IsExist(City entity)
        {
            if (!IsExistById(entity.Id))
            {
                return dbContext.cities.Any(x => x.Name == entity.Name);
            }
            else
            {
                return true;
            }
        }

        public bool IsExistById(int Id)
        {
           return dbContext.cities.Any(x => x.Id == Id);
        }

        public void Update(City entity)
        {
            if (IsExist(entity))
            {
                City oldCity = Get(entity.Id);
                oldCity.Name=entity.Name;
                dbContext.cities.Update(oldCity);
                dbContext.SaveChanges();
            }
        }
    }
}
