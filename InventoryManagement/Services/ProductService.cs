using System;
using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ProductService(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task CreateProduct(ProductDTO product)
        {
            await _db.Products.AddAsync(_mapper.Map<Product>(product));
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProduct(ProductDTO product)
        {
            _db.Products.Remove(_mapper.Map<Product>(product));
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProductById(int id)
        {
            var associatedBatches = await _db.Batches.Where(p => p.ProductId == id).ToListAsync();
            _db.Batches.RemoveRange(associatedBatches);
            _db.Products.Remove(await _db.Products.FindAsync(id));
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            var allProducts = await _db.Products.ToListAsync();
            foreach (var product in allProducts)
            {
                var associatedBatches = await _db.Batches.Where(p => p.ProductId == product.ProductId).ToListAsync();
                product.Batches = associatedBatches;
            }
            return _mapper.Map<IEnumerable<ProductDTO>>(allProducts);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await _db.Products.FindAsync(id);
            if (product == null)
            {
                return null;
            }
            product.Batches = await _db.Batches.Where(p => p.ProductId == product.ProductId).ToListAsync();
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<bool> ProductExistsById(int id)
        {
            return await _db.Products.Where(p => p.ProductId == id).AnyAsync();
        }

        public async Task<bool> ProductExistsByName(string name)
        {
            return await _db.Products.Where(p => p.Name == name).AnyAsync();
        }

        public async Task UpdateProduct(ProductDTO productDto)
        {
            _db.Products.Update(_mapper.Map<Product>(productDto));
            await _db.SaveChangesAsync();
        }

        public async Task ClearProductTable()
        {
            _db.RemoveRange(_db.Products.ToArrayAsync());
            await _db.SaveChangesAsync();
        }

        public async Task<List<string>> GetAllCategories()
        {
            return await Task.Run(() => Enum.GetNames(typeof(Categories)).ToList());
        }
        public async Task<IEnumerable<ProductDTO>> GetProductByCategory(string category)
        {
            var result = new List<Product>();

            if (string.IsNullOrWhiteSpace(category))
            {
                result = await _db.Products.ToListAsync();
            }
            else
            {
                category = category.ToLower();
                result.AddRange(await _db.Products.Where(p => p.Category.ToLower() == category).ToListAsync());
            }

            foreach (var product in result)
            {
                var associatedBatches = await _db.Batches.Where(p => p.ProductId == product.ProductId).ToListAsync();
                product.Batches = associatedBatches;
            }
            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }
        public async Task<IEnumerable<ProductDTO>> SearchProduct(string keyword = null, string category = null)
        {
            var result = new List<Product>();

            if (string.IsNullOrWhiteSpace(keyword) && string.IsNullOrWhiteSpace(category))
            {
                result = await _db.Products.ToListAsync();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    if (!string.IsNullOrWhiteSpace(category))
                    {
                        result.AddRange(await _db.Products.Where(p => p.Category.ToLower() == category).ToListAsync());
                    }
                    return _mapper.Map<IEnumerable<ProductDTO>>(result);
                }

                keyword = keyword.ToLower();
                if (!string.IsNullOrWhiteSpace(category))
                {
                    category = category.ToLower();
                    result.AddRange(await _db.Products.Where(p => p.Category == category).ToListAsync());
                    result = result.Where(p => 
                        p.ProductId.ToString().Contains(keyword) 
                        || p.Name.ToLower().Contains(keyword) 
                        || p.Brand.ToLower().Contains(keyword)).ToList();
                    return _mapper.Map<IEnumerable<ProductDTO>>(result.Distinct().ToList());
                }
                result.AddRange(await _db.Products.Where(p => 
                    p.ProductId.ToString().Contains(keyword)
                    || p.Name.ToLower().Contains(keyword) 
                    || p.Brand.ToLower().Contains(keyword)).ToListAsync());
            }
            
            foreach (var product in result)
            {
                var associatedBatches = await _db.Batches.Where(p => p.ProductId == product.ProductId).ToListAsync();
                product.Batches = associatedBatches;
            }
            
            return _mapper.Map<IEnumerable<ProductDTO>>(result.Distinct().ToList());
        }
    }
}
