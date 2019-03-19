using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SMEAPI.Models
{
    [Table("SALES_ORDER")]
    public class SalesOrder
    {
        [Key]
        public int SO_ID {get; set; }
        [MaxLength(50)]
        public String SITE{ get; set; }
        [MaxLength(100)]
        public String TRUSTME_CUSTOMER_REFERENCE{ get; set; }
        [MaxLength(50)]
        public String PURCHASE_ORDER_NO{ get; set; }
        [MaxLength(50)]
        public String PURCHASE_ORDER_REFERENCE{ get; set; }
        [MaxLength(8)]
        public String PO_DATE{ get; set; }
        [MaxLength(14)]
        public String UPDATE_DATETIME{ get; set; }
        [MaxLength(14)]
        public String CREATION_DATETIME{ get; set; }
        [MaxLength(14)]
        public String SUBMISSION_DATETIME{ get; set; }
        [MaxLength(50)]
        public String BRANCH_CODE{ get; set; }
        [MaxLength(300)]
        public String BRANCH_ADDRESS{ get; set; }
        [MaxLength(10)]
        public String AMOUNT{ get; set; }
        [MaxLength(50)]
        public String CURRENCY{ get; set; }
        [MaxLength(50)]
        public String PURCHASE_TYPE{ get; set; }
        [MaxLength(50)]
        public String STAFF_CODE{ get; set; }
        [MaxLength(50)]
        public String SUPPLIER_NAME{ get; set; }
        [MaxLength(50)]
        public String BRANCH_COUNTRY{ get; set; }
        [MaxLength(50)]
        public String BRANCH_PROVINCE_STATE{ get; set; }
        [MaxLength(50)]
        public String BRANCH_CITY{ get; set; }
        [MaxLength(50)]
        public String BRANCH_AREA{ get; set; }
        [MaxLength(50)]
        public String BRANCH_STREET{ get; set; }
        [MaxLength(10)]
        public String BRANCH_STREET_NO{ get; set; }
        [MaxLength(50)]
        public String BRANCH_BUILDING{ get; set; }
        [MaxLength(4)]
        public String BRANCH_FLOOR{ get; set; }
        [MaxLength(3)]
        public String BRANCH_FLAT{ get; set; }
        public ICollection<AccountPayable> AccountPayables { get; set; }
        public ICollection<PoTransaction> PoTransactions { get; set; }

    }
}
