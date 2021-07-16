using System.Collections.Generic;
using System.Linq;
using InventoryManagement.Controllers.Models;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Services
{
    public static class Converter
    {
        public static Product ProductDtoToDb(ProductDTO product)
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

        public static ProductDTO ProductToDto(Product product)
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
        
        public static Batch BatchDtoToDb(BatchDTO batchDto)
        {
            return new Batch
            {
                Manufacturer = batchDto.Manufacturer,
                Cost = batchDto.Cost,
                ExpirationDate = batchDto.ExpirationDate,
                PurchasedDate = batchDto.PurchasedDate,
                ProductId = batchDto.ProductId,
                Quantities = batchDto.Quantities,
                Product = ProductDtoToDb(batchDto.Product)
            };
        }
        
        public static ProductResponse ProductDtoToResponse(ProductDTO productDto)
        {
            return new ProductResponse
            {
                Name = productDto.Name,
                Brand = productDto.Brand,
                Category = productDto.Category,
                Location = productDto.Location,
                OnSale = productDto.OnSale,
                ProductId = productDto.ProductId,
                Price = productDto.Price,
                Quantities = productDto.Quantities,
                Batches = productDto.Batches.Select(x => new BatchResponse
                {
                    BatchId = x.BatchId,
                    Cost = x.Cost,
                    ExpirationDate = x.ExpirationDate,
                    Manufacturer = x.Manufacturer,
                    ProductId = x.ProductId,
                    PurchasedDate = x.PurchasedDate,
                    Quantities = x.Quantities
                }).ToList()
            };
        }

        public static ProductsResponse ProductsDtoToResponse(IEnumerable<ProductDTO> productsDto)
        {
            var response = new List<ProductResponse>();

            foreach (var product in productsDto)
            {
                response.Add(ProductDtoToResponse(product));
            }

            return new ProductsResponse
            {
                Products = response
            };
        }
    }
}