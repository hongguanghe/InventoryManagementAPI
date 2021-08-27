using System.Collections;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InventoryManagement.Controllers.Models;
using InventoryManagement.Services.DTOs;

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
        public async Task<IEnumerable<ProductResponse>> GetAllProducts()
        {
            var allProductDto = await _productService.GetAllProducts();
            return _mapper.Map<IEnumerable<ProductResponse>>(allProductDto);
        }
        
        [HttpGet("categories", Name = "All Categories")]
        public async Task<IEnumerable<string>> GetAllCategories()
        {
            return await _productService.GetAllCategories();
        }

        [HttpGet("products/product/{id:int}", Name = "One Product")]
        public async Task<ProductResponse> GetProductById(int id)
        {
            var productDto = await _productService.GetProductById(id);
            return _mapper.Map<ProductResponse>(productDto);
        }
        
        [HttpPut ("products/product/{id}", Name ="Update Product")]
        public async Task<ActionResult> UpdateProduct([FromBody]ProductDTO productDto)
        {
            if (!await _productService.ProductExistsById(productDto.ProductId))
            {
                return NotFound();
            }
            await _productService.UpdateProduct(productDto);
            return Ok();
        }

        // [HttpDelete("products/product/{id}", Name ="Delete Product")]
        // public async Task<ActionResult> DeleteProduct(ProductDTO productDto)
        // {
        //     if (!await _productService.ProductExistsById(productDto.ProductId))
        //     {
        //         return NotFound();
        //     }
        //     await _batchService.DeleteAllAssociatedBatches(productDto.Batches);
        //     await _productService.DeleteProduct(productDto);
        //     return Ok();        
        // }
        
        [HttpDelete("products/product/{id}", Name ="Delete Product")]
        public async Task<ActionResult> DeleteProductById(int id)
        {
            if (!await _productService.ProductExistsById(id))
            {
                return NotFound();
            }
            await _productService.DeleteProductById(id);
            return Ok();        
        }

        [HttpGet("products/product/search", Name = "Search Products")]
        public async Task<IEnumerable<ProductResponse>> SearchProducts(string keyword, string category)
        {
            var result = await _productService.SearchProduct(keyword, category);
            return _mapper.Map<IEnumerable<ProductResponse>>(result);
        }

        [HttpGet("products/product/category", Name = "Get Products by Category")]
        public async Task<IEnumerable<ProductResponse>> GetProductsByCategory(string category)
        {
            var result = await _productService.GetProductByCategory(category);
            return _mapper.Map<IEnumerable<ProductResponse>>(result);
        }

        [HttpPost("products/product/create", Name ="Create Product")]
        public async Task<ActionResult> CreateProduct(ProductDTO productDto)
        {
            if (await _productService.ProductExistsByName(productDto.Name))
            {
                return BadRequest();
            }
            await _productService.CreateProduct(productDto);
            return Ok();
        }

        [HttpGet("batches/batch/{id}", Name = "Get One Batch")]
        public async Task<BatchResponse> GetBatch(int id)
        {
            return _mapper.Map<BatchResponse>(await _batchService.GetBatchById(id));
        }
        
        [HttpPost("batches/batch/create", Name = "Create One Batch")]
        public async Task<ActionResult> CreateBatch(BatchDTO batchDto)
        {
            await _batchService.CreateBatch(batchDto);
            return Ok();        
        }
        
        [HttpDelete("batches/batch/{id}", Name = "Delete One Batch")]
        public async Task<ActionResult> DeleteBatch(int id)
        {
            if (!await _batchService.BatchExistsById(id))
            {
                return NotFound();
            }
            await _batchService.DeleteBatchById(id);
            return Ok();
        }
                
        [HttpPut("batches/batch/{id}", Name = "Update One Batch")]
        public async Task<ActionResult> UpdateBatch([FromBody]BatchDTO batchDto)
        {
            if (!await _batchService.BatchExistsById(batchDto.BatchId))
            {
                return NotFound();
            }
            await _batchService.UpdateBatch(batchDto);
            return Ok();
        }
        
        [HttpGet("products/{productId}/batches", Name = "Get Associated Batches")]
        public async Task<List<BatchResponse>> GetAssociateBatch(int productId)
        {
            var batchesResult = await _batchService.GetAllAssociatedBatches(productId);
            return batchesResult.ToList().Select(x => _mapper.Map<BatchResponse>(x)).ToList();
        }
    }
}
