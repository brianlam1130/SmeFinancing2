using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMEAPI.Models
{
    [Table("PO_TRANSACTION")]
    public class PoTransaction
    {
        [Key]
        public int ID {get; set;}
        [Required]
        [MaxLength(50)]
        public String PRODUCT_SERVICE_NAME {get; set; }
        [Required]
        [MaxLength(50)]
        public String PRODUCT_SERVICE_CODE {get; set; }
        [Required]
        public int PRODUCT_SERVICE_QUANTITY {get; set; }
        [Required]
        public int GROSS_PRICE {get; set; }
        [Required]
        public int NET_PRICE { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
