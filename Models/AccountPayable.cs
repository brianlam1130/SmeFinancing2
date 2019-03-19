using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SMEAPI.Models
{
    [Table("Account_Payable")]
    public class AccountPayable
    {
        [Key]
        public int AP_ID {get; set; }
        //public String PURCHASE_ORDER_NO{ get; set; }
        public String INVOICE_NO { get; set; }
        public String INVOICE_REFERENCE { get; set; }
        public String INVOICE_ISSUE_DATE { get; set; }
        public String SUBMISSION_DATETIME { get; set; }
        public String CREATION_DATETIME { get; set; }
        public String SYSTEM_OPERATION { get; set; }
        public String PAYMENT_DUE_DATE { get; set; }
        public int PAYMENT_TERMS { get; set; }
        public int INVOICE_AMOUNT { get; set; }
        public String CURRENCY { get; set; }
        public String TOTAL_BALANCE { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public ICollection<PoPosPayment> PoPosPayments { get; set; }

    }
}
