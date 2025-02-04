using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Universidad.GestionFinanciera.Domain.Models;
using Universidad.GestionFinanciera.Infrastructure.Data;

namespace Universidad.GestionFinanciera.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinanceController : ControllerBase
    {
        private readonly FinanceContext _context;

        public FinanceController(FinanceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Finance>> Get()
        {
            return _context.Finances.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Finance> Get(int id)
        {
            var finance = _context.Finances.Find(id);
            if (finance == null)
            {
                return NotFound();
            }
            return finance;
        }

        [HttpPost]
        public ActionResult<Finance> Post(Finance finance)
        {
            _context.Finances.Add(finance);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = finance.Id }, finance);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Finance finance)
        {
            if (id != finance.Id)
            {
                return BadRequest();
            }

            _context.Entry(finance).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var finance = _context.Finances.Find(id);
            if (finance == null)
            {
                return NotFound();
            }

            _context.Finances.Remove(finance);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
