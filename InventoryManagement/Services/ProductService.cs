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
        private readonly ApplicationDBContext _db;
        private readonly IMapper _mapper;
        public ProductService(ApplicationDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task CreateProduct(ProductDTO product)
        {
            // await _db.Products.AddAsync(Converter.ProductDtoToDb(product));
            await _db.Products.AddAsync(_mapper.Map<Product>(product));
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProduct(ProductDTO product)
        {
            // _db.Products.Remove(Converter.ProductDtoToDb(product));
            _db.Products.Remove(_mapper.Map<Product>(product));
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProductById(int id)
        {
            _db.Products.Remove(await _db.Products.FindAsync(id));
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            var allProducts = await _db.Products.ToListAsync();
            // var dtoProducts = new List<ProductDTO>();
            //
            // foreach (var product in allProducts)
            // {
            //     dtoProducts.Add(Converter.ProductToDto(product));
            // }
            return _mapper.Map<IEnumerable<ProductDTO>>(allProducts);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            return _mapper.Map<ProductDTO>(await _db.Products.FindAsync(id));
            // var product = await _db.Products.FindAsync(id);
            // return Converter.ProductToDto(product);
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
            // _db.Products.Update(Converter.ProductDtoToDb(product));
            _db.Products.Update(_mapper.Map<Product>(productDto));
            await _db.SaveChangesAsync();
        }

        public async Task ClearProductTable()
        {
            _db.RemoveRange(_db.Products.ToArrayAsync());
            await _db.SaveChangesAsync();
        }
    }
}
