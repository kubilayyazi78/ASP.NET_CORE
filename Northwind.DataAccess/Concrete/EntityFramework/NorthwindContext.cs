using Microsoft.EntityFrameworkCore;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb\mssqllocaldb;Database=Northwind;Trusted_Conntection=true");
        }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
