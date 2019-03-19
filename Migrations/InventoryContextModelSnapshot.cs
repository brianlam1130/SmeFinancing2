﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMEAPI.Models;

namespace SMEAPI.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SMEAPI.Models.AccountPayable", b =>
                {
                    b.Property<int>("AP_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATION_DATETIME");

                    b.Property<string>("CURRENCY");

                    b.Property<int>("INVOICE_AMOUNT");

                    b.Property<string>("INVOICE_ISSUE_DATE");

                    b.Property<string>("INVOICE_NO");

                    b.Property<string>("INVOICE_REFERENCE");

                    b.Property<string>("PAYMENT_DUE_DATE");

                    b.Property<int>("PAYMENT_TERMS");

                    b.Property<int?>("PurchaseOrderPO_ID");

                    b.Property<string>("SUBMISSION_DATETIME");

                    b.Property<string>("SYSTEM_OPERATION");

                    b.Property<string>("TOTAL_BALANCE");

                    b.HasKey("AP_ID");

                    b.HasIndex("PurchaseOrderPO_ID");

                    b.ToTable("Account_Payable");
                });

            modelBuilder.Entity("SMEAPI.Models.Assessment", b =>
                {
                    b.Property<int>("AssessmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CA_AMOUNT_DUE_FROM_DIRECTORS");

                    b.Property<int>("CA_AMOUNT_DUE_FROM_RELATED_COMPANY");

                    b.Property<int>("CA_CASH_BALANCE");

                    b.Property<int>("CA_DEPOSIT");

                    b.Property<int>("CA_INVENTORY");

                    b.Property<int>("CA_OTHERS");

                    b.Property<int>("CA_RECEIVABLE_WITH_RELATED_CO");

                    b.Property<string>("CA_RECEIVABLE_WITH_RELATED_CO_NOTE")
                        .HasMaxLength(100);

                    b.Property<int>("CA_REPAYMENT");

                    b.Property<int>("CL_ACCRUALS");

                    b.Property<int>("CL_AMOUNT_DUE_TO_DIRECTORS");

                    b.Property<int>("CL_AMOUNT_DUE_TO_RELATED_COMPANY");

                    b.Property<int>("CL_BANK_LOAN");

                    b.Property<int>("CL_BANK_OD");

                    b.Property<int>("CL_BILLS_PAYABLE");

                    b.Property<int>("CL_OBLIGATION_UNDER_FINANCE_LEASE");

                    b.Property<int>("CL_OTHERS");

                    b.Property<int>("CL_TOTAL_CURRENT_LIABILITIES");

                    b.Property<int>("CL_TRADE_DEPOSIT_RECEIVED");

                    b.Property<int>("CL_TRADE_PAYABLE");

                    b.Property<string>("FUNDAMENTAL_UNCERTAINTY")
                        .HasMaxLength(50);

                    b.Property<int>("IS_BANK_CHARGES");

                    b.Property<int>("IS_COST_OF_GOODS_SOLD");

                    b.Property<int>("IS_DEPRECIATION");

                    b.Property<int>("IS_DIRECTOR_REMUERATION");

                    b.Property<int>("IS_EXTRAORDINARY_LOSS");

                    b.Property<int>("IS_EXTRAORDINARY_PROFIT");

                    b.Property<int>("IS_INTEREST_EXPENSES");

                    b.Property<int>("IS_NET_PROFIT_AFTER_TAX");

                    b.Property<int>("IS_OTHER_INCOME");

                    b.Property<int>("IS_PAYROLL_EXPENSES");

                    b.Property<int>("IS_RENT_RATE");

                    b.Property<int>("IS_REVENUE");

                    b.Property<int>("IS_SALES_TO_RELATED_PARTY");

                    b.Property<int>("IS_TAX");

                    b.Property<int>("MA_AMOUNT_DUE_FROMA_RELATED_PARTIES");

                    b.Property<int>("MA_NON_RECOVERABLE");

                    b.Property<string>("MA_NON_RECOVERABLE_NOTE")
                        .HasMaxLength(100);

                    b.Property<string>("NAME_OF_AUDITOR")
                        .HasMaxLength(50);

                    b.Property<int>("NCA_AMOUNT_DUE_FROM_DIRECTORS");

                    b.Property<int>("NCA_INVESTMENT_IN_RELATED_COMPANY");

                    b.Property<int>("NCA_OTHERS");

                    b.Property<int>("NCA_PROPERTY_EQUIPMENT");

                    b.Property<int>("NCL_AMOUNT_DUE_TO_DIRECTORS");

                    b.Property<int>("NCL_AMOUNT_DUE_TO_RELATED_COMPANY");

                    b.Property<int>("NCL_BANK_LOAN");

                    b.Property<int>("NCL_OBLIGATION_UNDER_FINANCE_LEASE");

                    b.Property<int>("NCL_OTHERS");

                    b.Property<int>("NCL_TOTAL_NON_CURRENT_LIABILITIES");

                    b.Property<int>("NW_OFF_BALANCE_SHEET_ASSETS_PLEDGED");

                    b.Property<string>("NW_OFF_BALANCE_SHEET_ASSETS_PLEDGED_NOTE")
                        .HasMaxLength(100);

                    b.Property<int>("NW_TOTAL_EQUITY");

                    b.Property<int>("PERIOD_OF_ACCOUNTING");

                    b.Property<int>("TOTAL_CURENT_ASSETS");

                    b.Property<int>("TOTAL_NON_CURRENT_ASSETS");

                    b.Property<string>("TRUSTME_CUSTOMER_REFERENCE")
                        .HasMaxLength(100);

                    b.Property<string>("TYPE_OF_REPORT")
                        .HasMaxLength(7);

                    b.Property<string>("YEAR_ENDED_PERIOD")
                        .HasMaxLength(10);

                    b.HasKey("AssessmentID");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("SMEAPI.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("COMMITTED_STOCK");

                    b.Property<int>("COST");

                    b.Property<string>("CREATION_DATETIME")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<string>("DATE_IN")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("DATE_OUT")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("EXPIRY_DATE")
                        .HasMaxLength(8);

                    b.Property<int>("INCOMING_STOCK");

                    b.Property<string>("INVENTORY_LOCATION")
                        .HasMaxLength(150);

                    b.Property<string>("INV_REFERENCE")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ITEM_CODE")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ITEM_NAME")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("QUANTITY");

                    b.Property<string>("SITE")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("STOCK_BALANCE");

                    b.Property<string>("STOCK_LOCATION")
                        .HasMaxLength(50);

                    b.Property<string>("SUBMISSION_DATETIME")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<string>("SUPPLIER_CODE")
                        .HasMaxLength(50);

                    b.Property<string>("SYSTEM_OPERATION")
                        .HasMaxLength(1);

                    b.Property<string>("TRUSTME_CUSTOMER_REFERENCE")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("InventoryID");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("SMEAPI.Models.PoPosPayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AMOUNT")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int?>("AccountPayableAP_ID");

                    b.Property<string>("CREDIT_CATEGORY")
                        .HasMaxLength(10);

                    b.Property<string>("CURRENCY")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PURCHASE_ORDER_NO")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PURCHASE_PAYMENT_REFERENCE")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("VERIFIED_CREDIT")
                        .HasMaxLength(1);

                    b.HasKey("ID");

                    b.HasIndex("AccountPayableAP_ID");

                    b.ToTable("PO_POS_PAYMENT");
                });

            modelBuilder.Entity("SMEAPI.Models.PoTransaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GROSS_PRICE");

                    b.Property<int>("NET_PRICE");

                    b.Property<string>("PRODUCT_SERVICE_CODE")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PRODUCT_SERVICE_NAME")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PRODUCT_SERVICE_QUANTITY");

                    b.Property<int?>("PurchaseOrderPO_ID");

                    b.HasKey("ID");

                    b.HasIndex("PurchaseOrderPO_ID");

                    b.ToTable("PO_TRANSACTION");
                });

            modelBuilder.Entity("SMEAPI.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("PO_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AMOUNT")
                        .HasMaxLength(10);

                    b.Property<string>("BRANCH_ADDRESS")
                        .HasMaxLength(300);

                    b.Property<string>("BRANCH_AREA")
                        .HasMaxLength(50);

                    b.Property<string>("BRANCH_BUILDING")
                        .HasMaxLength(50);

                    b.Property<string>("BRANCH_CITY")
                        .HasMaxLength(50);

                    b.Property<string>("BRANCH_CODE")
                        .HasMaxLength(50);

                    b.Property<string>("BRANCH_COUNTRY")
                        .HasMaxLength(50);

                    b.Property<string>("BRANCH_FLAT")
                        .HasMaxLength(3);

                    b.Property<string>("BRANCH_FLOOR")
                        .HasMaxLength(4);

                    b.Property<string>("BRANCH_PROVINCE_STATE")
                        .HasMaxLength(50);

                    b.Property<string>("BRANCH_STREET")
                        .HasMaxLength(50);

                    b.Property<string>("BRANCH_STREET_NO")
                        .HasMaxLength(10);

                    b.Property<string>("CREATION_DATETIME")
                        .HasMaxLength(14);

                    b.Property<string>("CURRENCY")
                        .HasMaxLength(50);

                    b.Property<string>("PO_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("PURCHASE_ORDER_NO")
                        .HasMaxLength(50);

                    b.Property<string>("PURCHASE_ORDER_REFERENCE")
                        .HasMaxLength(50);

                    b.Property<string>("PURCHASE_TYPE")
                        .HasMaxLength(50);

                    b.Property<string>("SITE")
                        .HasMaxLength(50);

                    b.Property<string>("STAFF_CODE")
                        .HasMaxLength(50);

                    b.Property<string>("SUBMISSION_DATETIME")
                        .HasMaxLength(14);

                    b.Property<string>("SUPPLIER_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("TRUSTME_CUSTOMER_REFERENCE")
                        .HasMaxLength(100);

                    b.Property<string>("UPDATE_DATETIME")
                        .HasMaxLength(14);

                    b.HasKey("PO_ID");

                    b.ToTable("Purchase_Order");
                });

            modelBuilder.Entity("SMEAPI.Models.AccountPayable", b =>
                {
                    b.HasOne("SMEAPI.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany("AccountPayables")
                        .HasForeignKey("PurchaseOrderPO_ID");
                });

            modelBuilder.Entity("SMEAPI.Models.PoPosPayment", b =>
                {
                    b.HasOne("SMEAPI.Models.AccountPayable", "AccountPayable")
                        .WithMany("PoPosPayments")
                        .HasForeignKey("AccountPayableAP_ID");
                });

            modelBuilder.Entity("SMEAPI.Models.PoTransaction", b =>
                {
                    b.HasOne("SMEAPI.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PoTransactions")
                        .HasForeignKey("PurchaseOrderPO_ID");
                });
#pragma warning restore 612, 618
        }
    }
}