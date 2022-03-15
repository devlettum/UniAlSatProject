using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlar.
    public class UniSellContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=UniSell;Trusted_Connection=true");
        }

        public DbSet<Advert> Adverts{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<User> Users{ get; set; }
    }
}
