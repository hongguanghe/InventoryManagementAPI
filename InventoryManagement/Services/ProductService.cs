using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDBContext _db;
        public ProductService(ApplicationDBContext db)
        {
            _db = db;
        }
        public async Task CreateProduct(Product product)
        {
            await _db.Products.AddAsync(product);
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

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _db.Products.ToArrayAsync();
        }

        public async Task<Product> GetProductById(int Id)
        {
            return await _db.Products.FindAsync(Id);
        }

        public async Task<bool> ProductExistsById(int Id)
        {
            return await _db.Products.Where(p => p.Id == Id).AnyAsync();
        }

        public async Task<bool> ProductExistsByName(string Name)
        {
            return await _db.Products.Where(p => p.Name == Name).AnyAsync();
        }

        public async Task UpdateProduct(Product product)
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
