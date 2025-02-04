using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Universidad.GestionContable.Domain.Models;
using Universidad.GestionContable.Infrastructure.Data;

namespace Universidad.GestionContable.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountingController : ControllerBase
    {
        private readonly AccountingContext _context;

        public AccountingController(AccountingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Accounting>> Get()
        {
            return _context.Accountings.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Accounting> Get(int id)
        {
            var accounting = _context.Accountings.Find(id);
            if (accounting == null)
            {
                return NotFound();
            }
            return accounting;
        }

        [HttpPost]
        public ActionResult<Accounting> Post(Accounting accounting)
        {
            _context.Accountings.Add(accounting);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = accounting.Id }, accounting);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Accounting accounting)
        {
            if (id != accounting.Id)
            {
                return BadRequest();
            }

            _context.Entry(accounting).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var accounting = _context.Accountings.Find(id);
            if (accounting == null)
            {
                return NotFound();
            }

            _context.Accountings.Remove(accounting);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
