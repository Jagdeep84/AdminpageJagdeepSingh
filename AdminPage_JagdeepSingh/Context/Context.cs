using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AdminPage_JagdeepSingh.Models;


namespace AdminPage_JagdeepSingh.Contexts
{
   public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().Property("discount").HasColumnType("decimal").HasPrecision(18, 2);
            modelBuilder.Entity<OrderDetail>().Property("unitPrice").HasColumnType("decimal").HasPrecision(18, 2);
            modelBuilder.Entity<Product>().Property("dicounted").HasColumnType("decimal").HasPrecision(18, 2);
            modelBuilder.Entity<Product>().Property("unitPrice").HasColumnType("decimal").HasPrecision(18, 2);


        }



        
    }
}
