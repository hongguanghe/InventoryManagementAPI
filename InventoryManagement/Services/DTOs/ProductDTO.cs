using System.Collections.Generic;
using System.Linq;
using InventoryManagement.Data.Entities;

namespace InventoryManagement.Services.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }
        public string Location { get; set; }
        public List<BatchDTO> Batches { get; set; }
        
        public double Cost => Batches.Select(x => x.Cost).Average();
        public int Quantities => Batches.Select(x => x.Quantities).Sum();
    }
}