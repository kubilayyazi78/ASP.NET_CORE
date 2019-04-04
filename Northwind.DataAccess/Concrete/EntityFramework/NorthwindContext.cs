using Microsoft.EntityFrameworkCore;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
   public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");    
        }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
