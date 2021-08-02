using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProducts();
        Task<IEnumerable<ProductDTO>> GetProductByCategory(string category);
        Task<IEnumerable<ProductDTO>> SearchProduct(string keyword, string category = null);
        Task<ProductDTO> GetProductById(int id);
        Task<bool> ProductExistsById(int id);
        Task<bool> ProductExistsByName(string name);
        Task DeleteProductById(int id);
        Task DeleteProduct(ProductDTO product);
        Task CreateProduct(ProductDTO product);
        Task UpdateProduct(ProductDTO productDto);
        Task ClearProductTable();
        Task<List<string>> GetAllCategories();
    }
}
