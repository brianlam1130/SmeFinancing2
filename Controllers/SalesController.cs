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
    public class SalesController : ControllerBase
    {

        private readonly InventoryContext _context;

        private ILogger _logger;

        public SalesController(InventoryContext context, ILogger<SalesController> logger)
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
        public async Task<ActionResult<IEnumerable<Inventory>>> GetInventorys()
        {
            return await _context.Inventorys.ToListAsync();
        }
        */

        // GET: api/inventory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inventory>> GetInventory(int id)
        {
            var inventory = await _context.Inventorys.FindAsync(id);

            _logger.LogInformation("Brian1111: " + "");

            if (inventory == null)
            {
                return NotFound();
            }

            return inventory;
        }

        // POST api/inventory
        [HttpPost]
        //public void Post([FromBody] Inventory data)
        public void Post([FromBody] List<Inventory> data)
        {
            if (data != null)
            {
                foreach(var orp in data)
                {
                _context.Add(orp);
                }
                //_context.Add(data);
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