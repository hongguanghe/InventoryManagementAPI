using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement
{
    public class Product
    {
        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; }
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Category { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }
        public double Cost { get; set; }
        public string Location { get; set; }
        public int Quantities { get; set; }
        public List<Batch> Batches { get; set; }
    }
}
