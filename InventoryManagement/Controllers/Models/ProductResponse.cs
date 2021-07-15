using System.Collections.Generic;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Controllers.Models
{
    public class ProductResponse
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }
        public string Location { get; set; }
        public int Quantities { get; set; }
        public double Cost { get; set; }
        public List<Batch> Batches { get; set; }
        // BATCH(Probably) OR BATCHDTO? 
    }
}