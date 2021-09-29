using System;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public Northwind(DbContextOptions<Northwind> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category);

            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerID)
                .IsRequired()
                .HasMaxLength(5);

            modelBuilder.Entity<Customer>()
                .Property(c => c.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            modelBuilder.Entity<Customer>()
                .Property(c => c.ContactName)
                .HasMaxLength(30);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Country)
                .HasMaxLength(15);

            
        }
    }
}
