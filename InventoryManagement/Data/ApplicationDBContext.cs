using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Batch> Batches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                ProductId = 1,
                Brand = "BrandA",
                Category = "Fashion",
                Location = "A8",
                Name = "Product A",
                OnSale = true,
                Price = 9.00
                },
                new Product()
                {
                    ProductId = 2,
                    Brand = "BrandB",
                    Category = "Electronics",
                    Location = "A2",
                    Name = "Electronics Example Product",
                    OnSale = false,
                    Price = 99.98
                },
                new Product()
                {
                    ProductId = 3,
                    Brand = "BrandC",
                    Category = "Home",
                    Location = "C8",
                    Name = "Water Bottle",
                    OnSale = true,
                    Price = 25.98
                }
            ); 
            
            modelBuilder.Entity<Batch>().HasData(
                new Batch
                {
                    BatchId = 1,
                    Cost = 9.00,
                    ExpirationDate = DateTime.UtcNow.AddDays(200),
                    Manufacturer = "M1",
                    ProductId = 1,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 500
                },
                new Batch
                {
                    BatchId = 2,
                    Cost = 8.00,
                    ExpirationDate = DateTime.UtcNow.AddDays(400),
                    Manufacturer = "M1",
                    ProductId = 1,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 20
                },
                new Batch
                {
                    BatchId = 3,
                    Cost = 7.00,
                    ExpirationDate = DateTime.UtcNow.AddDays(100),
                    Manufacturer = "M1",
                    ProductId = 1,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 50
                },
                new Batch
                {
                    BatchId = 4,
                    Cost = 9.00,
                    ExpirationDate = DateTime.UtcNow.AddDays(200),
                    Manufacturer = "E1 Inc.",
                    ProductId = 2,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 533
                },
                new Batch
                {
                    BatchId = 5,
                    Cost = 18.00,
                    ExpirationDate = DateTime.UtcNow.AddDays(400),
                    Manufacturer = "E1 Inc.",
                    ProductId = 2,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 66
                },
                new Batch
                {
                    BatchId = 6,
                    Cost = 759.50,
                    ExpirationDate = DateTime.UtcNow.AddDays(100),
                    Manufacturer = "E1 Inc.",
                    ProductId = 2,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 80
                },
                new Batch
                {
                    BatchId = 7,
                    Cost = 22.03,
                    ExpirationDate = DateTime.UtcNow.AddDays(200),
                    Manufacturer = "Bottle Inc",
                    ProductId = 3,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 500
                },
                new Batch
                {
                    BatchId = 8,
                    Cost = 29.88,
                    ExpirationDate = DateTime.UtcNow.AddDays(400),
                    Manufacturer = "Bottle Inc",
                    ProductId = 3,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 20
                },
                new Batch
                {
                    BatchId = 9,
                    Cost = 18.55,
                    ExpirationDate = DateTime.UtcNow.AddDays(100),
                    Manufacturer = "Bottle Inc",
                    ProductId = 3,
                    PurchasedDate = DateTime.UtcNow,
                    Quantities = 50
                }
                );

        }
    }
}
