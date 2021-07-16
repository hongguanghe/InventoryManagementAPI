﻿using InventoryManagement.Data;
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
            await _db.Products.AddAsync(ProductToDb(product));
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            // TODO: DELETE BATCHES AS WELL
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();

        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            var allProducts = await _db.Products.ToListAsync();
            var dtoProducts = new List<ProductDTO>();

            foreach (var product in allProducts)
            {
                dtoProducts.Add(ProductToDto(product));
            }

            return dtoProducts;
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await _db.Products.FindAsync(id);
            return ProductToDto(product);
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
            _db.Products.Update(ProductToDb(product));
            await _db.SaveChangesAsync();
        }

        public async Task ClearDatabase()
        {
            _db.RemoveRange(_db.Products.ToArrayAsync());
            await _db.SaveChangesAsync();
        }

        public Product ProductToDb(ProductDTO product)
        {
            return new Product
            {
                Name = product.Name,
                Batches = product.Batches.Select(x => new Batch
                {
                    Cost = x.Cost,
                    ExpirationDate = x.ExpirationDate,
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
        }

        public ProductDTO ProductToDto(Product product)
        {
            return new ProductDTO
            {
                Batches = product.Batches.Select(x => new BatchDTO()
                {
                    Cost = x.Cost,
                    ExpirationDate = x.ExpirationDate,
                    Manufacturer = x.Manufacturer,
                    PurchasedDate = x.PurchasedDate,
                    Quantities = x.Quantities
                }).ToList(),
                Brand = product.Brand,
                Category = product.Category,
                OnSale = product.OnSale,
                Price = product.Price,
                Location = product.Location,
                ProductId = product.ProductId,
                Name = product.Name
            };
        }
    }
}
