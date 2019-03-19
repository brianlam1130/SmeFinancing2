using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMEAPI.Models
{
    [Table("Inventory")]
    public class Inventory
    {
        [Key]
        public int InventoryID {get; set; }
        [Required]
        [MaxLength(50)]
        public String SITE {get; set; }
        [Required]
        [MaxLength(100)]
        public String TRUSTME_CUSTOMER_REFERENCE {get; set; }
        [Required]
        [MaxLength(50)]
        public String INV_REFERENCE {get; set; }
        [Required]
        [MaxLength(50)]
        public String ITEM_NAME {get; set; }
        [Required]
        [MaxLength(50)]
        public String ITEM_CODE {get; set; }
        [Required]
        public int QUANTITY {get; set; }
        [Required]
        public int COST {get; set; }
        [Required]
        [MaxLength(8)]
        public String DATE_IN {get; set; }
        [Required]
        [MaxLength(8)]
        public String DATE_OUT {get; set; }
        [Required]
        [MaxLength(14)]
        public String SUBMISSION_DATETIME {get; set; }
        [Required]
        [MaxLength(14)]
        public String CREATION_DATETIME {get; set; }
        [MaxLength(1)]
        public String SYSTEM_OPERATION {get; set; }
        [MaxLength(150)]
        public String INVENTORY_LOCATION {get; set; }
        [MaxLength(8)]
        public String EXPIRY_DATE {get; set; }
        public int COMMITTED_STOCK {get; set; }
        public int INCOMING_STOCK {get; set; }
        public int STOCK_BALANCE {get; set; }
        [MaxLength(50)]
        public String STOCK_LOCATION {get; set; }
        [MaxLength(50)]
        public String SUPPLIER_CODE {get; set; }

    }
}
