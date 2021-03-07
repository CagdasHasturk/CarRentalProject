using System;
using System.Collections.Generic;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentalContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433\Catalog=CarRental;Database=CarRental;User=sa;Password=someThingComplicated1234;");
        }

        public DbSet<Car> Cars{ get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Rental> Rentals {get; set;}

    }
}
