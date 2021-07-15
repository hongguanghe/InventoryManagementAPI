﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<bool> ProductExistsById(int id);
        Task<bool> ProductExistsByName(string name);
        Task DeleteProduct(int id);
        Task CreateProduct(ProductDTO product);
        Task UpdateProduct(ProductDTO product);
        Task ClearDatabase();
    }
}
