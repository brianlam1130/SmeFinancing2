using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SMEAPI.Models
{
    [Table("PO_POS_PAYMENT")]
    public class PoPosPayment
    {
        [Key]
        public int ID {get; set;}
        [Required]
        [MaxLength(50)]
        public String PURCHASE_PAYMENT_REFERENCE {get; set; }
        [Required]
        [MaxLength(50)]
        public String PURCHASE_ORDER_NO {get; set; }
        [MaxLength(10)]
        public String CREDIT_CATEGORY {get; set; }
        [Required]
        [MaxLength(10)]
        public String AMOUNT {get; set; }
        [Required]
        [MaxLength(50)]
        public String CURRENCY {get; set; }
        [MaxLength(1)]
        public String VERIFIED_CREDIT {get; set; }
        public AccountPayable AccountPayable { get; set; }
    }
}
