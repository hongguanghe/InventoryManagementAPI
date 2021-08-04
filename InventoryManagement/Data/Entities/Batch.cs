using System;

namespace InventoryManagement.Data.Entities
{
    public class Batch
    {
        public int BatchId { get; set; }
        public int Quantities { get; set; }
        public double Cost { get; set; }
        public string Manufacturer { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        
        // foreign key to navigation property
        public int ProductId { get; set; }
        
        // navigation property - indicate relationship
        public Product Product { get; set; }
    }
}
