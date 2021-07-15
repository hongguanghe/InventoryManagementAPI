﻿using InventoryManagement.Data;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.Controllers.Models;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Controllers
{
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {

        private readonly ApplicationDBContext _db;
        private readonly IProductService _productService;

        public InventoryController(ApplicationDBContext db, IProductService productService)
        {
            _db = db;
            _productService = productService;
        }

        [HttpGet("products/all", Name = "All Products")]
        public async Task<IEnumerable<ProductResponse>> GetAllProducts()
        {
            // TODO: RETURN PRODUCTRESPONSE
            // GET THE RESPONSE FROM THE SERVICE AND MAP IT TO PRODUCT RESPONSE
            return await _productService.GetAllProducts();
        }

        [HttpGet("products/product/{Id}", Name = "One Product")]
        public async Task<Product> GetProductById(int Id)
        {
            // TODO: RETURN PRODUCTRESPONSE
            // GET THE RESPONSE FROM THE SERVICE AND MAP IT TO PRODUCT RESPONSE
            return await _productService.GetProductById(Id);
        }

        [HttpDelete("products/product/{Id}", Name ="Delete Product")]
        public async Task<ActionResult> DeleteProduct(int Id)
        {
            await _productService.DeleteProduct(Id);
            return Ok();
        }

        [HttpPost("products/demo", Name = "Add Demo")]
        public async Task<ActionResult> LoadDemoData()
        {
            //await _productService.ClearDatabase();
            var demoProducts = new List<ProductDTO>();

            // ------------------Product 1 -------------------
            var product1 = new ProductDTO
            {
                //Id = Guid.NewGuid().ToString(),
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
                //AssociatedProductId = 10
            };

            var batch2List1 = new BatchDTO
            {
                Quantities = 100,
                Cost = 12.55,
                Manufacturer = "Tide Inc.",
                PurchasedDate = new System.DateTime(),
                ExpirationDate = new System.DateTime(2025, 5, 6),
                //AssociatedProductId = 10
            };

            var batch3List1 = new BatchDTO
            {
                Quantities = 300,
                Cost = 18.55,
                Manufacturer = "Tide Inc.",
                PurchasedDate = new System.DateTime(),
                ExpirationDate = new System.DateTime(2025, 5, 25),
                //AssociatedProductId = 10
            };
            batchesList1.Add(batch1List1);
            batchesList1.Add(batch2List1);
            batchesList1.Add(batch3List1);
            product1.Batches = batchesList1;
            demoProducts.Add(product1);

            // ------------------Product 2 -------------------
            var product2 = new ProductDTO
            {
                //Id = Guid.NewGuid().ToString(),
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
                //AssociatedProductId = 15
            };

            var batch2List2 = new BatchDTO
            {
                Cost = 12.55,
                Manufacturer = "Sterilite Company",
                PurchasedDate = new System.DateTime(2016, 12, 8),
                ExpirationDate = new System.DateTime(2028, 8, 8),
                //AssociatedProductId = 15
            };

            batchesList2.Add(batch1List2);
            batchesList2.Add(batch2List2);
            product2.Batches = batchesList2;
            demoProducts.Add(product2);

            // ------------------Product 3 -------------------
            var product3 = new ProductDTO
            {
                //Id = Guid.NewGuid().ToString(),
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
                //AssociatedProductId = 16
            };

            var batch2List3 = new BatchDTO
            {
                Quantities = 10,
                Cost = 35.00,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2012, 12, 8),
                ExpirationDate = new System.DateTime(2022, 8, 8),
                //AssociatedProductId = 16
            };

            var batch3List3 = new BatchDTO
            {
                Quantities = 5,
                Cost = 32.66,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2018, 1, 8),
                ExpirationDate = new System.DateTime(2020, 3, 28),
                //AssociatedProductId = 16
            };

            var batch4List3 = new BatchDTO
            {
                Quantities = 5,
                Cost = 49.55,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2020, 7, 5),
                ExpirationDate = new System.DateTime(2028, 8, 15),
                //AssociatedProductId = 16
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

        private ProductResponse ConvertDTO(ProductDTO productDto)
        {
            return null;
        }
    }
}
