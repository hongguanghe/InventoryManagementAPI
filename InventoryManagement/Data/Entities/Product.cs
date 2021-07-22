using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Data.Entities
{
    public class Product
    {
        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; }
        [Key]
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }
        public string Location { get; set; }
        public List<Batch> Batches { get; set; }
    }
}
