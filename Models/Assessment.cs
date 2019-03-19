using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMEAPI.Models
{
    public class Assessment
    {
        [Key]
        public int AssessmentID {get; set; }
        [MaxLength(100)]
        public String TRUSTME_CUSTOMER_REFERENCE{ get; set; }
        [MaxLength(10)]
        public String YEAR_ENDED_PERIOD{ get; set; }    
        public int PERIOD_OF_ACCOUNTING{ get; set; }
        [MaxLength(7)]
        public String TYPE_OF_REPORT{ get; set; }
        [MaxLength(50)]
        public String NAME_OF_AUDITOR{ get; set; }
        [MaxLength(50)]
        public String FUNDAMENTAL_UNCERTAINTY{ get; set; }
        public int TOTAL_CURENT_ASSETS{ get; set; }
        public int CA_CASH_BALANCE{ get; set; }
        public int CA_RECEIVABLE_WITH_RELATED_CO{ get; set; }
        [MaxLength(100)]
        public String CA_RECEIVABLE_WITH_RELATED_CO_NOTE{ get; set; }
        public int CA_INVENTORY{ get; set; }
        public int CA_AMOUNT_DUE_FROM_RELATED_COMPANY{ get; set; }
        public int CA_AMOUNT_DUE_FROM_DIRECTORS{ get; set; }
        public int CA_DEPOSIT{ get; set; }
        public int CA_REPAYMENT{ get; set; }
        public int CA_OTHERS{ get; set; }
        public int TOTAL_NON_CURRENT_ASSETS{ get; set; }
        public int NCA_PROPERTY_EQUIPMENT{ get; set; }
        public int NCA_AMOUNT_DUE_FROM_DIRECTORS{ get; set; }
        public int NCA_INVESTMENT_IN_RELATED_COMPANY{ get; set; }
        public int NCA_OTHERS{ get; set; }
        public int MA_NON_RECOVERABLE{ get; set; }
        [MaxLength(100)]
        public String MA_NON_RECOVERABLE_NOTE{ get; set; }
        public int MA_AMOUNT_DUE_FROMA_RELATED_PARTIES{ get; set; }
        public int CL_TOTAL_CURRENT_LIABILITIES{ get; set; }
        public int CL_TRADE_PAYABLE{ get; set; }
        public int CL_BANK_OD{ get; set; }
        public int CL_BILLS_PAYABLE{ get; set; }
        public int CL_BANK_LOAN{ get; set; }
        public int CL_OBLIGATION_UNDER_FINANCE_LEASE{ get; set; }
        public int CL_AMOUNT_DUE_TO_RELATED_COMPANY{ get; set; }
        public int CL_AMOUNT_DUE_TO_DIRECTORS{ get; set; }
        public int CL_TRADE_DEPOSIT_RECEIVED{ get; set; }
        public int CL_ACCRUALS{ get; set; }
        public int CL_OTHERS{ get; set; }
        public int NCL_TOTAL_NON_CURRENT_LIABILITIES{ get; set; }
        public int NCL_BANK_LOAN{ get; set; }
        public int NCL_OBLIGATION_UNDER_FINANCE_LEASE{ get; set; }
        public int NCL_AMOUNT_DUE_TO_RELATED_COMPANY{ get; set; }
        public int NCL_AMOUNT_DUE_TO_DIRECTORS{ get; set; }
        public int NCL_OTHERS{ get; set; }
        public int NW_TOTAL_EQUITY{ get; set; }
        public int NW_OFF_BALANCE_SHEET_ASSETS_PLEDGED{ get; set; }
        [MaxLength(100)]
        public String NW_OFF_BALANCE_SHEET_ASSETS_PLEDGED_NOTE{ get; set; }
        public int IS_REVENUE{ get; set; }
        public int IS_COST_OF_GOODS_SOLD{ get; set; }
        public int IS_OTHER_INCOME{ get; set; }
        public int IS_EXTRAORDINARY_PROFIT{ get; set; }
        public int IS_BANK_CHARGES{ get; set; }
        public int IS_INTEREST_EXPENSES{ get; set; }
        public int IS_DEPRECIATION{ get; set; }
        public int IS_DIRECTOR_REMUERATION{ get; set; }
        public int IS_PAYROLL_EXPENSES{ get; set; }
        public int IS_RENT_RATE{ get; set; }
        public int IS_TAX{ get; set; }
        public int IS_EXTRAORDINARY_LOSS{ get; set; }
        public int IS_NET_PROFIT_AFTER_TAX{ get; set; }
        public int IS_SALES_TO_RELATED_PARTY{ get; set; }
    }
}
