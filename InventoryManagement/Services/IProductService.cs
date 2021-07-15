using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int Id);
        Task<bool> ProductExistsById(int Id);
        Task<bool> ProductExistsByName(string Name);
        Task DeleteProduct(int Id);
        Task CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task ClearDatabase();
    }
}
