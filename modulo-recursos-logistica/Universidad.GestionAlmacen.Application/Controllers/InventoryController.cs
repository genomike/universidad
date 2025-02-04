using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Universidad.GestionAlmacen.Domain.Models;
using Universidad.GestionAlmacen.Infrastructure.Data;

namespace Universidad.GestionAlmacen.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly InventoryContext _context;

        public InventoryController(InventoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Inventory>> Get()
        {
            return _context.Inventories.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Inventory> Get(int id)
        {
            var inventory = _context.Inventories.Find(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return inventory;
        }

        [HttpPost]
        public ActionResult<Inventory> Post(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = inventory.Id }, inventory);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Inventory inventory)
        {
            if (id != inventory.Id)
            {
                return BadRequest();
            }

            _context.Entry(inventory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var inventory = _context.Inventories.Find(id);
            if (inventory == null)
            {
                return NotFound();
            }

            _context.Inventories.Remove(inventory);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
