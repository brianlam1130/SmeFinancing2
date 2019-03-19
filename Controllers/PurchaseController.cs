using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMEAPI.Models;
using Microsoft.Extensions.Logging;

namespace SMEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly InventoryContext _context;

        private ILogger _logger;

        public PurchaseController(InventoryContext context, ILogger<PurchaseController> logger)
        {
            _context = context;
            _logger = logger;

            /*
            if (_context.Inventorys.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Inventorys.Add(new Inventory { SITE = "Site1", TRUSTME_CUSTOMER_REFERENCE = "Trustme Customer Reference 1" });
                _context.SaveChanges();
            }*/
        }

        /*
        // GET: api/inventory
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<PurchaseOrder>>> GetPurchaseOrder()
        public IEnumerable<PurchaseOrder> GetPurchaseOrder()
        {
            //return await _context.PurchaseOrders.ToListAsync();

            return _context.PurchaseOrders.Include(p => p.AccountPayables).ThenInclude(e=> e.PoPosPayments).Include(e=> e.PoTransactions);
        }*/

        // GET: api/inventory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrder>> GetPurchaseOrder(int id)
        {
            //var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);

            var purchaseOrder = await _context.PurchaseOrders.Include(e=> e.AccountPayables).ThenInclude(e=> e.PoPosPayments).Include(e=> e.PoTransactions).FirstOrDefaultAsync(e => e.PO_ID == id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            _logger.LogInformation("Brian1111: " + purchaseOrder.AccountPayables.Count);
            _logger.LogInformation("Brian1111: " + purchaseOrder.PoTransactions.Count);

            return purchaseOrder;
        }

        // POST api/inventory
        [HttpPost]
        public void Post([FromBody] PurchaseOrder data)
        {
            if (data != null)
            {
                _context.Add(data);
                _context.SaveChanges();
            }

            /*
            Further more backend operation
             */
        }

        // DELETE api/inventory/5
        /*
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var inventory = _context.Inventorys.Find(id);

            // Add something to check inventory is null or not
            _context.Inventorys.Remove(inventory);
            _context.SaveChanges();

        }
        */
    }
}