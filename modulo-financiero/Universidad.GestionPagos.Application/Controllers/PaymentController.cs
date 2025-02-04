using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Universidad.GestionPagos.Domain.Models;
using Universidad.GestionPagos.Infrastructure.Data;

namespace Universidad.GestionPagos.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentContext _context;

        public PaymentController(PaymentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Payment>> Get()
        {
            return _context.Payments.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Payment> Get(int id)
        {
            var payment = _context.Payments.Find(id);
            if (payment == null)
            {
                return NotFound();
            }
            return payment;
        }

        [HttpPost]
        public ActionResult<Payment> Post(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = payment.Id }, payment);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Payment payment)
        {
            if (id != payment.Id)
            {
                return BadRequest();
            }

            _context.Entry(payment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var payment = _context.Payments.Find(id);
            if (payment == null)
            {
                return NotFound();
            }

            _context.Payments.Remove(payment);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
