using System;

namespace InventoryManagement.Controllers.Models
{
    public class BatchResponse
    {
        public int BatchId { get; set; }
        public int Quantities { get; set; }
        public double Cost { get; set; }
        public string Manufacturer { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int ProductId { get; set; }
    }
}