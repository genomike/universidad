using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Universidad.GestionVentas.Domain.Models;
using Universidad.GestionVentas.Infrastructure.Data;

namespace Universidad.GestionVentas.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly SaleContext _context;

        public SaleController(SaleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sale>> Get()
        {
            return _context.Sales.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Sale> Get(int id)
        {
            var sale = _context.Sales.Find(id);
            if (sale == null)
            {
                return NotFound();
            }
            return sale;
        }

        [HttpPost]
        public ActionResult<Sale> Post(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = sale.Id }, sale);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Sale sale)
        {
            if (id != sale.Id)
            {
                return BadRequest();
            }

            _context.Entry(sale).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var sale = _context.Sales.Find(id);
            if (sale == null)
            {
                return NotFound();
            }

            _context.Sales.Remove(sale);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
