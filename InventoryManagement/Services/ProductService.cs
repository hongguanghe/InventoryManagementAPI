using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDBContext _db;
        public ProductService(ApplicationDBContext db)
        {
            _db = db;
        }
        public async Task CreateProduct(ProductDTO product)
        {
            var productToDB = new Product
            {
                Name = product.Name,
                Batches = product.Batches.Select(x => new Batch
                {
                    Cost = x.Cost,
                    ExpirationDate = x.ExpirationDate,
                    Location =  x.Location,
                    Manufacturer = x.Manufacturer,
                    PurchasedDate = x.PurchasedDate,
                    Quantities = x.Quantities
                }).ToList(),
                Brand = product.Brand,
                Category = product.Category,
                OnSale = product.OnSale,
                Price = product.Price,
                Location = product.Location,
                Quantities = product.Quantities
            };
            
            await _db.Products.AddAsync(productToDB);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            // TODO: DELETE BATCHES AS WELL
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();

        }

        public Task DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            return await _db.Products.ToList();
        }

        public async Task<ProductDTO> GetProductById(int Id)
        {
            return await _db.Products.FindAsync(Id);
        }

        public async Task<bool> ProductExistsById(int Id)
        {
            return await _db.Products.Where(p => p.ProductId == Id).AnyAsync();
        }

        public async Task<bool> ProductExistsByName(string Name)
        {
            return await _db.Products.Where(p => p.Name == Name).AnyAsync();
        }

        public async Task UpdateProduct(ProductDTO product)
        {
            
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
        }

        public async Task ClearDatabase()
        {
            _db.RemoveRange(_db.Products.ToArrayAsync());
            await _db.SaveChangesAsync();
        }
    }
}
