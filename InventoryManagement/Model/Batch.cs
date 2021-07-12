using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class Batch
    {
        public string Id { get; set; }
        public int Quantities { get; set; }
        public double Cost { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Location { get; set; }
    }
}
