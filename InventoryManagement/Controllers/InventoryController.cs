using InventoryManagement.Data;
using InventoryManagement.Model;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public Task<IEnumerable<Product>> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("products/product/{Id}", Name = "One Product")]
        public async Task<Product> GetProductById(int Id)
        {
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
            var demoProducts = new List<Product>();

            // ------------------Product 1 -------------------
            var product1 = new Product
            {
                //Id = Guid.NewGuid().ToString(),
                Name = "Pods Spring Meadow 96 Ct, Laundry Detergent Pacs",
                Brand = "Tide",
                Category = 2,
                Price = 21.44,
                OnSale = true,
                Location = "A1",
                Quantities = 500
            };

            var batchesList1 = new List<Batch>();
            var batch1List1 = new Batch
            {
                Quantities = 100,
                Cost = 9.88,
                Manufacturer = "Tide Inc.",
                PurchasedDate = new System.DateTime(),
                ExpirationDate = new System.DateTime(2025, 5, 1),
                Location = "B2",
                //AssociatedProductId = 10
            };

            var batch2List1 = new Batch
            {
                Quantities = 100,
                Cost = 12.55,
                Manufacturer = "Tide Inc.",
                PurchasedDate = new System.DateTime(),
                ExpirationDate = new System.DateTime(2025, 5, 6),
                Location = "B2",
                //AssociatedProductId = 10
            };

            var batch3List1 = new Batch
            {
                Quantities = 300,
                Cost = 18.55,
                Manufacturer = "Tide Inc.",
                PurchasedDate = new System.DateTime(),
                ExpirationDate = new System.DateTime(2025, 5, 25),
                Location = "B3",
                //AssociatedProductId = 10
            };
            batchesList1.Add(batch1List1);
            batchesList1.Add(batch2List1);
            batchesList1.Add(batch3List1);
            product1.Batches = batchesList1;
            demoProducts.Add(product1);

            // ------------------Product 2 -------------------
            var product2 = new Product
            {
                //Id = Guid.NewGuid().ToString(),
                Name = "Plastic Set of(4) 12 Qt.Storage Boxes Blush Pink",
                Brand = "Sterilite",
                Category = 1,
                Price = 8.00,
                OnSale = false,
                Location = "C5",
                Quantities = 200
            };

            var batchesList2 = new List<Batch>();
            var batch1List2 = new Batch
            {
                Quantities = 100,
                Cost = 9.88,
                Manufacturer = "Sterilite Company",
                PurchasedDate = new System.DateTime(2015, 5, 1),
                ExpirationDate = new System.DateTime(2025, 8, 1),
                Location = "A2"
                //AssociatedProductId = 15
            };

            var batch2List2 = new Batch
            {
                Quantities = 100,
                Cost = 12.55,
                Manufacturer = "Sterilite Company",
                PurchasedDate = new System.DateTime(2016, 12, 8),
                ExpirationDate = new System.DateTime(2028, 8, 8),
                Location = "A2"
                //AssociatedProductId = 15
            };

            batchesList2.Add(batch1List2);
            batchesList2.Add(batch2List2);
            product2.Batches = batchesList2;
            demoProducts.Add(product2);

            // ------------------Product 3 -------------------
            var product3 = new Product
            {
                //Id = Guid.NewGuid().ToString(),
                Name = "Comfort Wireless Combo Keyboard and Mouse",
                Brand = "Logitech",
                Category = 5,
                Price = 48.88,
                OnSale = true,
                Location = "E2",
                Quantities = 50
            };

            var batchesList3 = new List<Batch>();
            var batch1List3 = new Batch
            {
                Quantities = 30,
                Cost = 38.00,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2008, 5, 1),
                ExpirationDate = new System.DateTime(2012, 8, 1),
                Location = "C6"
                //AssociatedProductId = 16
            };

            var batch2List3 = new Batch
            {
                Quantities = 10,
                Cost = 35.00,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2012, 12, 8),
                ExpirationDate = new System.DateTime(2022, 8, 8),
                Location = "C6"
                //AssociatedProductId = 16
            };

            var batch3List3 = new Batch
            {
                Quantities = 5,
                Cost = 32.66,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2018, 1, 8),
                ExpirationDate = new System.DateTime(2020, 3, 28),
                Location = "C7"
                //AssociatedProductId = 16
            };

            var batch4List3 = new Batch
            {
                Quantities = 5,
                Cost = 49.55,
                Manufacturer = "Logitech Inc",
                PurchasedDate = new System.DateTime(2020, 7, 5),
                ExpirationDate = new System.DateTime(2028, 8, 15),
                Location = "C7"
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

    }
}
