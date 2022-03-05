using Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Models;

namespace ECommerce
{
    public class EcommorceDbContext:DbContext
    {

        public const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ECommerceDb;Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        public DbSet<Governrote> governrotes { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Mobile> mobiles { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
    }
}
