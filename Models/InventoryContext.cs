using Microsoft.EntityFrameworkCore;

namespace SMEAPI.Models{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory> Inventorys { get; set; }

        public DbSet<Assessment> Assessments { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        public DbSet<AccountPayable> AccountPayables { get; set; }

        public DbSet<PoPosPayment> PoPosPayments { get; set; }
        public DbSet<PoTransaction> PoTransactions { get; set; }

    }
}