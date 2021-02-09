using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : DB tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        //senin projen hangi veritabanı ile ilişkili belirtilen yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind; Trusted_Connection=true");
        }

        //Benim Product nesnemi veri tabanındaki Products ile bağla (benim hangi classım hangi tabloya denk geliyor)
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
