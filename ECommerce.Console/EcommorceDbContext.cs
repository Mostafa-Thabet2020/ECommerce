using ECommerce.Console.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Console
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
    }
}
