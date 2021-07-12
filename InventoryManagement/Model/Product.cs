using InventoryManagement.Model;
using System;

namespace InventoryManagement
{
    public class Product
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }
        public double Cost { get; set; }
        public string location { get; set; }
        public int Quantities { get; set; }
        public Batch[] MyProperty { get; set; }
    }
}
