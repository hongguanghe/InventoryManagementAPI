using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
