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
            var random = new Random();
            
            var brands = new []
            {
                "sanction",
                "expression",
                "contact",
                "sigh",
                "impress", 
                "production", 
                "adapt",
                "comparison",
                "circle",
                "testimony",
                "suppose",
                "boom",
                "mere",
                "greatest",
                "cover",
                "independence",
                "software",
                "post",
                "system",
                "dress",
                "taxpayer",
                "ground",
                "exactly",
                "circumstance", 
                "precisely", 
                "egg", 
                "agricultural", 
                "border",
                "board", 
                "mark", 
                "wonderful", 
                "cast", 
                "married", 
                "during", 
                "detect"
            };
            var colors = new []
            {
                "Air Force blue",
                "Alice blue",
                "Alizarin crimson",
                "Almond",
                "Amaranth",
                "Amber",
                "American rose",
                "Amethyst",
                "Android Green",
                "Anti-flash white",
                "Antique brass",
                "Antique fuchsia",
                "Antique white",
                "Ao",
                "Apple green",
                "Apricot",
                "Aqua",
                "Aquamarine",
                "Army green",
                "Arylide yellow",
                "Ash grey",
                "Asparagus"
            };
            var names = new []
            {
                "zipper",
                "wagon",
                "model car",
                "bow",
                "sharpie",
                "soap",
                "toothbrush",
                "street lights",
                "couch",
                "candy wrapper",
                "deodorant",
                "apple",
                "perfume",
                "bag",
                "door",
                "cup",
                "clock",
                "canvas",
                "eye liner",
                "bed",
                "rug",
                "video games",
                "clay pot",
                "tooth picks",
                "mouse pad",
                "radio",
                "purse",
                "spoon",
                "pants",
                "eraser"
            };
            var allProducts = new List<Product>();
            var allBatches = new List<Batch>();

            for (var i = 1; i < 51; i++)
            {
                var randomCategory = random.Next(0, 7);
                var randomPrice = Math.Round(random.NextDouble() * 100.33, 2);
                var product = new Product
                {
                    ProductId = i,
                    Brand = brands[random.Next(0, brands.Length)],
                    Category = ((Categories) randomCategory).ToString(),
                    Location = 'A' + random.Next(0, 10).ToString(),
                    Name = colors[random.Next(0, colors.Length)] + ' ' + names[random.Next(0, names.Length)],
                    OnSale = random.NextDouble() >= 0.5,
                    Price = randomPrice
                };
                allProducts.Add(product);
                var numBatches = random.Next(0, 6);
                
                for (var k = 0; k < numBatches; k++)
                {
                    var positiveDays = random.Next(0, 720);
                    var negativeDays = positiveDays * -1;
                    var randomQuantities = random.Next(1, 500);
                    var batch = new Batch
                    {
                        BatchId = allBatches.Count + 1,
                        Cost = Math.Round(random.NextDouble() * 100.33, 2),
                        ExpirationDate = DateTime.UtcNow.AddDays(positiveDays),
                        Manufacturer = brands[random.Next(0, brands.Length)],
                        ProductId = i,
                        PurchasedDate = DateTime.UtcNow.AddDays(negativeDays),
                        Quantities = randomQuantities,
                    };
                    allBatches.Add(batch);
                }
            }
            
            modelBuilder.Entity<Product>().HasData(allProducts);
            modelBuilder.Entity<Batch>().HasData(allBatches);
        }
    }
}
