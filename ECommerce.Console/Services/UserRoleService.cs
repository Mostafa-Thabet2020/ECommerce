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
    public class UserRoleService : IUserRoleRepository
    {
        EcommorceDbContext dbContext = new EcommorceDbContext();
        public void Add(UserRole entity)
        {
            if (!IsExist(entity))
            {
                dbContext.userRoles.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public UserRole Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserRole> Get()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(UserRole entity)
        {
            return dbContext.userRoles.Any(x => x.Id == entity.Id || x.Name == entity.Name);
        }

        public bool IsExistById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserRole entity)
        {
            throw new NotImplementedException();
        }
    }
}
