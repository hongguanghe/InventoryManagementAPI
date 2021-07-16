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
            await _db.Products.AddAsync(Converter.ProductDtoToDb(product));
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProduct(ProductDTO product)
        {
            _db.Products.Remove(Converter.ProductDtoToDb(product));
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProductById(int id)
        {
            var product = await _db.Products.FindAsync(id);
            _db.Products.Remove(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            var allProducts = await _db.Products.ToListAsync();
            var dtoProducts = new List<ProductDTO>();

            foreach (var product in allProducts)
            {
                dtoProducts.Add(Converter.ProductToDto(product));
            }

            return dtoProducts;
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await _db.Products.FindAsync(id);
            return Converter.ProductToDto(product);
        }

        public async Task<bool> ProductExistsById(int id)
        {
            return await _db.Products.Where(p => p.ProductId == id).AnyAsync();
        }

        public async Task<bool> ProductExistsByName(string name)
        {
            return await _db.Products.Where(p => p.Name == name).AnyAsync();
        }

        public async Task UpdateProduct(ProductDTO product)
        {
            _db.Products.Update(Converter.ProductDtoToDb(product));
            await _db.SaveChangesAsync();
        }

        public async Task ClearProductTable()
        {
            _db.RemoveRange(_db.Products.ToArrayAsync());
            await _db.SaveChangesAsync();
        }
    }
}
