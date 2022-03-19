using ECommerce;
using ECommerce.Repository;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GovernroteService : IGovernroteRepository
    {
        EcommorceDbContext dbContext = new EcommorceDbContext();
        public void Add(Governrote entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                dbContext.governrotes.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void AddList(List<Governrote> governrotes)
        {
            dbContext.governrotes.AddRange(governrotes);
            dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                //Governrote entity = Get(Id);
                //dbContext.governrotes.Remove(entity);

                dbContext.governrotes.Remove(Get(Id));// quicke action
                dbContext.SaveChanges();
            }
        }

        public Governrote Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.governrotes.Where(x => x.Id == id).SingleOrDefault();
            }
            return null;
        }

        public List<Governrote> Get()
        {
            return dbContext.governrotes.ToList();
        }

        public bool IsEmpty()
        {
            return !dbContext.governrotes.Any();
        }

        public bool IsExist(Governrote entity)
        {
            if(!IsExistById(entity.Id))
            {
                return dbContext.governrotes.Any(x => x.Name == entity.Name);
            }
            else
            {
                return IsExistById(entity.Id);
            }
        }

        public bool IsExistById(int Id)
        {
            return dbContext.governrotes.Any(x => x.Id == Id);
        }

        public void Update(Governrote entity)
        {
            if (IsExist(entity))
            {
                Governrote oldGovernrote = Get(entity.Id);
                oldGovernrote.Name= entity.Name;
                dbContext.governrotes.Update(oldGovernrote);
                dbContext.SaveChanges();
            }
        }
    }
}
