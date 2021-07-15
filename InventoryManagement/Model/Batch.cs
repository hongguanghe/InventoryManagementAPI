using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class Batch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("AssociatedProductId")]
        public int Id { get; set; }
        public int Quantities { get; set; }
        public double Cost { get; set; }
        public string Manufacturer { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Location { get; set; }
        public virtual int AssociatedProductId { get; set; }
    }
}
