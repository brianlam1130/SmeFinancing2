using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMEAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    AssessmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TRUSTME_CUSTOMER_REFERENCE = table.Column<string>(maxLength: 100, nullable: true),
                    YEAR_ENDED_PERIOD = table.Column<string>(maxLength: 10, nullable: true),
                    PERIOD_OF_ACCOUNTING = table.Column<int>(nullable: false),
                    TYPE_OF_REPORT = table.Column<string>(maxLength: 7, nullable: true),
                    NAME_OF_AUDITOR = table.Column<string>(maxLength: 50, nullable: true),
                    FUNDAMENTAL_UNCERTAINTY = table.Column<string>(maxLength: 50, nullable: true),
                    TOTAL_CURENT_ASSETS = table.Column<int>(nullable: false),
                    CA_CASH_BALANCE = table.Column<int>(nullable: false),
                    CA_RECEIVABLE_WITH_RELATED_CO = table.Column<int>(nullable: false),
                    CA_RECEIVABLE_WITH_RELATED_CO_NOTE = table.Column<string>(maxLength: 100, nullable: true),
                    CA_INVENTORY = table.Column<int>(nullable: false),
                    CA_AMOUNT_DUE_FROM_RELATED_COMPANY = table.Column<int>(nullable: false),
                    CA_AMOUNT_DUE_FROM_DIRECTORS = table.Column<int>(nullable: false),
                    CA_DEPOSIT = table.Column<int>(nullable: false),
                    CA_REPAYMENT = table.Column<int>(nullable: false),
                    CA_OTHERS = table.Column<int>(nullable: false),
                    TOTAL_NON_CURRENT_ASSETS = table.Column<int>(nullable: false),
                    NCA_PROPERTY_EQUIPMENT = table.Column<int>(nullable: false),
                    NCA_AMOUNT_DUE_FROM_DIRECTORS = table.Column<int>(nullable: false),
                    NCA_INVESTMENT_IN_RELATED_COMPANY = table.Column<int>(nullable: false),
                    NCA_OTHERS = table.Column<int>(nullable: false),
                    MA_NON_RECOVERABLE = table.Column<int>(nullable: false),
                    MA_NON_RECOVERABLE_NOTE = table.Column<string>(maxLength: 100, nullable: true),
                    MA_AMOUNT_DUE_FROMA_RELATED_PARTIES = table.Column<int>(nullable: false),
                    CL_TOTAL_CURRENT_LIABILITIES = table.Column<int>(nullable: false),
                    CL_TRADE_PAYABLE = table.Column<int>(nullable: false),
                    CL_BANK_OD = table.Column<int>(nullable: false),
                    CL_BILLS_PAYABLE = table.Column<int>(nullable: false),
                    CL_BANK_LOAN = table.Column<int>(nullable: false),
                    CL_OBLIGATION_UNDER_FINANCE_LEASE = table.Column<int>(nullable: false),
                    CL_AMOUNT_DUE_TO_RELATED_COMPANY = table.Column<int>(nullable: false),
                    CL_AMOUNT_DUE_TO_DIRECTORS = table.Column<int>(nullable: false),
                    CL_TRADE_DEPOSIT_RECEIVED = table.Column<int>(nullable: false),
                    CL_ACCRUALS = table.Column<int>(nullable: false),
                    CL_OTHERS = table.Column<int>(nullable: false),
                    NCL_TOTAL_NON_CURRENT_LIABILITIES = table.Column<int>(nullable: false),
                    NCL_BANK_LOAN = table.Column<int>(nullable: false),
                    NCL_OBLIGATION_UNDER_FINANCE_LEASE = table.Column<int>(nullable: false),
                    NCL_AMOUNT_DUE_TO_RELATED_COMPANY = table.Column<int>(nullable: false),
                    NCL_AMOUNT_DUE_TO_DIRECTORS = table.Column<int>(nullable: false),
                    NCL_OTHERS = table.Column<int>(nullable: false),
                    NW_TOTAL_EQUITY = table.Column<int>(nullable: false),
                    NW_OFF_BALANCE_SHEET_ASSETS_PLEDGED = table.Column<int>(nullable: false),
                    NW_OFF_BALANCE_SHEET_ASSETS_PLEDGED_NOTE = table.Column<string>(maxLength: 100, nullable: true),
                    IS_REVENUE = table.Column<int>(nullable: false),
                    IS_COST_OF_GOODS_SOLD = table.Column<int>(nullable: false),
                    IS_OTHER_INCOME = table.Column<int>(nullable: false),
                    IS_EXTRAORDINARY_PROFIT = table.Column<int>(nullable: false),
                    IS_BANK_CHARGES = table.Column<int>(nullable: false),
                    IS_INTEREST_EXPENSES = table.Column<int>(nullable: false),
                    IS_DEPRECIATION = table.Column<int>(nullable: false),
                    IS_DIRECTOR_REMUERATION = table.Column<int>(nullable: false),
                    IS_PAYROLL_EXPENSES = table.Column<int>(nullable: false),
                    IS_RENT_RATE = table.Column<int>(nullable: false),
                    IS_TAX = table.Column<int>(nullable: false),
                    IS_EXTRAORDINARY_LOSS = table.Column<int>(nullable: false),
                    IS_NET_PROFIT_AFTER_TAX = table.Column<int>(nullable: false),
                    IS_SALES_TO_RELATED_PARTY = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.AssessmentID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InventoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SITE = table.Column<string>(maxLength: 50, nullable: false),
                    TRUSTME_CUSTOMER_REFERENCE = table.Column<string>(maxLength: 100, nullable: false),
                    INV_REFERENCE = table.Column<string>(maxLength: 50, nullable: false),
                    ITEM_NAME = table.Column<string>(maxLength: 50, nullable: false),
                    ITEM_CODE = table.Column<string>(maxLength: 50, nullable: false),
                    QUANTITY = table.Column<int>(nullable: false),
                    COST = table.Column<int>(nullable: false),
                    DATE_IN = table.Column<string>(maxLength: 8, nullable: false),
                    DATE_OUT = table.Column<string>(maxLength: 8, nullable: false),
                    SUBMISSION_DATETIME = table.Column<string>(maxLength: 14, nullable: false),
                    CREATION_DATETIME = table.Column<string>(maxLength: 14, nullable: false),
                    SYSTEM_OPERATION = table.Column<string>(maxLength: 1, nullable: true),
                    INVENTORY_LOCATION = table.Column<string>(maxLength: 150, nullable: true),
                    EXPIRY_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    COMMITTED_STOCK = table.Column<int>(nullable: false),
                    INCOMING_STOCK = table.Column<int>(nullable: false),
                    STOCK_BALANCE = table.Column<int>(nullable: false),
                    STOCK_LOCATION = table.Column<string>(maxLength: 50, nullable: true),
                    SUPPLIER_CODE = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.InventoryID);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Order",
                columns: table => new
                {
                    PO_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SITE = table.Column<string>(maxLength: 50, nullable: true),
                    TRUSTME_CUSTOMER_REFERENCE = table.Column<string>(maxLength: 100, nullable: true),
                    PURCHASE_ORDER_NO = table.Column<string>(maxLength: 50, nullable: true),
                    PURCHASE_ORDER_REFERENCE = table.Column<string>(maxLength: 50, nullable: true),
                    PO_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    UPDATE_DATETIME = table.Column<string>(maxLength: 14, nullable: true),
                    CREATION_DATETIME = table.Column<string>(maxLength: 14, nullable: true),
                    SUBMISSION_DATETIME = table.Column<string>(maxLength: 14, nullable: true),
                    BRANCH_CODE = table.Column<string>(maxLength: 50, nullable: true),
                    BRANCH_ADDRESS = table.Column<string>(maxLength: 300, nullable: true),
                    AMOUNT = table.Column<string>(maxLength: 10, nullable: true),
                    CURRENCY = table.Column<string>(maxLength: 50, nullable: true),
                    PURCHASE_TYPE = table.Column<string>(maxLength: 50, nullable: true),
                    STAFF_CODE = table.Column<string>(maxLength: 50, nullable: true),
                    SUPPLIER_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    BRANCH_COUNTRY = table.Column<string>(maxLength: 50, nullable: true),
                    BRANCH_PROVINCE_STATE = table.Column<string>(maxLength: 50, nullable: true),
                    BRANCH_CITY = table.Column<string>(maxLength: 50, nullable: true),
                    BRANCH_AREA = table.Column<string>(maxLength: 50, nullable: true),
                    BRANCH_STREET = table.Column<string>(maxLength: 50, nullable: true),
                    BRANCH_STREET_NO = table.Column<string>(maxLength: 10, nullable: true),
                    BRANCH_BUILDING = table.Column<string>(maxLength: 50, nullable: true),
                    BRANCH_FLOOR = table.Column<string>(maxLength: 4, nullable: true),
                    BRANCH_FLAT = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Order", x => x.PO_ID);
                });

            migrationBuilder.CreateTable(
                name: "Account_Payable",
                columns: table => new
                {
                    AP_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    INVOICE_NO = table.Column<string>(nullable: true),
                    INVOICE_REFERENCE = table.Column<string>(nullable: true),
                    INVOICE_ISSUE_DATE = table.Column<string>(nullable: true),
                    SUBMISSION_DATETIME = table.Column<string>(nullable: true),
                    CREATION_DATETIME = table.Column<string>(nullable: true),
                    SYSTEM_OPERATION = table.Column<string>(nullable: true),
                    PAYMENT_DUE_DATE = table.Column<string>(nullable: true),
                    PAYMENT_TERMS = table.Column<int>(nullable: false),
                    INVOICE_AMOUNT = table.Column<int>(nullable: false),
                    CURRENCY = table.Column<string>(nullable: true),
                    TOTAL_BALANCE = table.Column<string>(nullable: true),
                    PurchaseOrderPO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account_Payable", x => x.AP_ID);
                    table.ForeignKey(
                        name: "FK_Account_Payable_Purchase_Order_PurchaseOrderPO_ID",
                        column: x => x.PurchaseOrderPO_ID,
                        principalTable: "Purchase_Order",
                        principalColumn: "PO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PO_TRANSACTION",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PRODUCT_SERVICE_NAME = table.Column<string>(maxLength: 50, nullable: false),
                    PRODUCT_SERVICE_CODE = table.Column<string>(maxLength: 50, nullable: false),
                    PRODUCT_SERVICE_QUANTITY = table.Column<int>(nullable: false),
                    GROSS_PRICE = table.Column<int>(nullable: false),
                    NET_PRICE = table.Column<int>(nullable: false),
                    PurchaseOrderPO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PO_TRANSACTION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PO_TRANSACTION_Purchase_Order_PurchaseOrderPO_ID",
                        column: x => x.PurchaseOrderPO_ID,
                        principalTable: "Purchase_Order",
                        principalColumn: "PO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PO_POS_PAYMENT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PURCHASE_PAYMENT_REFERENCE = table.Column<string>(maxLength: 50, nullable: false),
                    PURCHASE_ORDER_NO = table.Column<string>(maxLength: 50, nullable: false),
                    CREDIT_CATEGORY = table.Column<string>(maxLength: 10, nullable: true),
                    AMOUNT = table.Column<string>(maxLength: 10, nullable: false),
                    CURRENCY = table.Column<string>(maxLength: 50, nullable: false),
                    VERIFIED_CREDIT = table.Column<string>(maxLength: 1, nullable: true),
                    AccountPayableAP_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PO_POS_PAYMENT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PO_POS_PAYMENT_Account_Payable_AccountPayableAP_ID",
                        column: x => x.AccountPayableAP_ID,
                        principalTable: "Account_Payable",
                        principalColumn: "AP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_Payable_PurchaseOrderPO_ID",
                table: "Account_Payable",
                column: "PurchaseOrderPO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PO_POS_PAYMENT_AccountPayableAP_ID",
                table: "PO_POS_PAYMENT",
                column: "AccountPayableAP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PO_TRANSACTION_PurchaseOrderPO_ID",
                table: "PO_TRANSACTION",
                column: "PurchaseOrderPO_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "PO_POS_PAYMENT");

            migrationBuilder.DropTable(
                name: "PO_TRANSACTION");

            migrationBuilder.DropTable(
                name: "Account_Payable");

            migrationBuilder.DropTable(
                name: "Purchase_Order");
        }
    }
}
