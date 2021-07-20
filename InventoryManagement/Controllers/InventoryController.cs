using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InventoryManagement.Controllers.Models;
using InventoryManagement.Services.DTOs;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagement.Controllers
{
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IBatchService _batchService;
        private readonly IMapper _mapper;
        
        public InventoryController(IProductService productService, IBatchService batchService, IMapper mapper)
        {
            _productService = productService;
            _batchService = batchService;
            _mapper = mapper;
        }

        [HttpGet("products/all", Name = "All Products")]
        public async Task<ProductsResponse> GetAllProducts()
        {
            var allProductDto = await _productService.GetAllProducts();
            return Converter.ProductsDtoToResponse(allProductDto);
        }

        [HttpGet("products/product/{id:int}", Name = "One Product")]
        public async Task<ProductResponse> GetProductById(int id)
        {
            var productDto = await _productService.GetProductById(id);
            return Converter.ProductDtoToResponse(productDto);
        }
        
        [HttpPatch ("products/product/{id}", Name ="Update Product")]
        public async Task<ActionResult> UpdateProduct(ProductDTO productDto)
        {
            if (!await _productService.ProductExistsById(productDto.ProductId))
            {
                return NotFound();
            }
            await _productService.UpdateProduct(productDto);
            return Ok();
        }

        [HttpDelete("products/product/{id}", Name ="Delete Product")]
        public async Task<ActionResult> DeleteProduct(ProductDTO productDto)
        {
            if (!await _productService.ProductExistsById(productDto.ProductId))
            {
                return NotFound();
            }
            await _batchService.DeleteAllAssociatedBatches(productDto.Batches);
            await _productService.DeleteProduct(productDto);
            return Ok();        
        }
        
        [HttpPost("products/product/create", Name ="Create Product")]
        public async Task<ActionResult> CreateProduct(ProductDTO productDto)
        {
            if (!await _productService.ProductExistsByName(productDto.Name))
            {
                return BadRequest();
            }
            await _productService.CreateProduct(productDto);
            return Ok();
        }

        [HttpGet("batches/batch/{id}", Name = "Get One Batch")]
        public async Task<BatchResponse> GetBatch(int id)
        {
            return Converter.BatchDtoToResponse(await _batchService.GetBatchById(id));
        }
        
        [HttpGet("batches/batch/create", Name = "Create One Batch")]
        public async Task<ActionResult> CreateBatch(BatchDTO batchDto)
        {
            if (!await _batchService.BatchExistsById(batchDto.BatchId))
            {
                return BadRequest();
            }
            await _batchService.CreateBatch(batchDto);
            return Ok();        }
        
        [HttpDelete("batches/batch/{id}", Name = "Delete One Batch")]
        public async Task<ActionResult> DeleteBatch(int id)
        {
            if (!await _batchService.BatchExistsById(id))
            {
                return NotFound();
            }
            await _batchService.GetBatchById(id);
            return Ok();
        }
                
        [HttpPatch("batches/batch/{id}", Name = "Update One Batch")]
        public async Task<ActionResult> UpdateBatch(BatchDTO batchDto)
        {
            if (!await _batchService.BatchExistsById(batchDto.BatchId))
            {
                return NotFound();
            }
            await _batchService.UpdateBatch(batchDto);
            return Ok();
        }
        
        [HttpGet("products/{productId}/batches", Name = "Get Associated Batches")]
        public async Task<BatchesResponse> GetAssociateBatch(int productId)
        {
            return Converter.BatchesDtoToResponse(await _batchService.GetAllAssociatedBatches(productId));
        }

        [HttpPost("products/demo", Name = "Add Demo")]
        public async Task<ActionResult> LoadDemoData()
        {
            var demoProducts = new List<ProductDTO>();

            // ------------------Product 1 -------------------
            var product1 = new ProductDTO
            {
                Name = "Pods Spring Meadow 96 Ct, Laundry Detergent Pacs",
                Brand = "Tide",
                Category = "Detergents",
                Price = 21.44,
                OnSale = true,
                Location = "A1",
            };

            var batchesList1 = new List<BatchDTO>();
            var batch1List1 = new BatchDTO
            {
                Quantities = 100,
                Cost = 9.88,
                Manufacturer = "Tide Inc.",
                PurchasedDate = new System.DateTime(),
                ExpirationDate = new System.DateTime(2025, 5, 1),
            };

            var batch2List1 = new BatchDTO
            {
                Quantities = 100,
                Cost = 12.55,
                Manufacturer = "Tide Inc.",
                PurchasedDate = new System.DateTime(),
                ExpirationDate = new System.DateTime(2025, 5, 6),
            };

            var batch3List1 = new BatchDTO
            {
                Quantities = 300,
                Cost = 18.55,
                Manufacturer = "Tide Inc.",
                PurchasedDate = new System.DateTime(),
                ExpirationDate = new System.DateTime(2025, 5, 25),
            };
            batchesList1.Add(batch1List1);
            batchesList1.Add(batch2List1);
            batchesList1.Add(batch3List1);
            product1.Batches = batchesList1;
            demoProducts.Add(product1);

            // ------------------Product 2 -------------------
            var product2 = new ProductDTO
            {
                Name = "Plastic Set of(4) 12 Qt.Storage Boxes Blush Pink",
                Brand = "Sterilite",
                Category = "Kitchen",
                Price = 8.00,
                OnSale = false,
                Location = "C5",
            };

            var batchesList2 = new List<BatchDTO>();
            var batch1List2 = new BatchDTO
            {
                Quantities = 100,
                Cost = 9.88,
                Manufacturer = "Sterilite Company",
                PurchasedDate = new System.DateTime(2015, 5, 1),
                ExpirationDate = new System.DateTime(2025, 8, 1),
            };

            var batch2List2 = new BatchDTO
            {
                Cost = 12.55,
                Manufacturer = "Sterilite Company",
                PurchasedDate = new System.DateTime(2016, 12, 8),
                ExpirationDate = new System.DateTime(2028, 8, 8),
            };

            batchesList2.Add(batch1List2);
            batchesList2.Add(batch2List2);
            product2.Batches = batchesList2;
            demoProducts.Add(product2);

            // ------------------Product 3 -------------------
            var product3 = new ProductDTO
            {
                Name = "Comfort Wireless Combo Keyboard and Mouse",
                Brand = "Logitech",
                Category = "Electronics",
                Price = 48.88,
                OnSale = true,
                Location = "E2",
            };

            var batchesList3 = new List<BatchDTO>();
            var batch1List3 = new BatchDTO
            {
                Quantities = 30,
                Cost = 38.00,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2008, 5, 1),
                ExpirationDate = new System.DateTime(2012, 8, 1),
            };

            var batch2List3 = new BatchDTO
            {
                Quantities = 10,
                Cost = 35.00,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2012, 12, 8),
                ExpirationDate = new System.DateTime(2022, 8, 8),
            };

            var batch3List3 = new BatchDTO
            {
                Quantities = 5,
                Cost = 32.66,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2018, 1, 8),
                ExpirationDate = new System.DateTime(2020, 3, 28),
            };

            var batch4List3 = new BatchDTO
            {
                Quantities = 5,
                Cost = 49.55,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2020, 7, 5),
                ExpirationDate = new System.DateTime(2028, 8, 15),
            };

            batchesList2.Add(batch1List3);
            batchesList2.Add(batch2List3);
            batchesList2.Add(batch3List3);
            batchesList2.Add(batch4List3);
            product2.Batches = batchesList3;
            demoProducts.Add(product3);

            foreach (var p in demoProducts)
            {
                await _productService.CreateProduct(p);
            }

            return Ok();
        }
    }
}
