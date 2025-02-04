using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Universidad.GestionLogistica.Domain.Models;
using Universidad.GestionLogistica.Infrastructure.Data;

namespace Universidad.GestionLogistica.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogisticsController : ControllerBase
    {
        private readonly LogisticsContext _context;

        public LogisticsController(LogisticsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Logistics>> Get()
        {
            return _context.Logistics.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Logistics> Get(int id)
        {
            var logistics = _context.Logistics.Find(id);
            if (logistics == null)
            {
                return NotFound();
            }
            return logistics;
        }

        [HttpPost]
        public ActionResult<Logistics> Post(Logistics logistics)
        {
            _context.Logistics.Add(logistics);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = logistics.Id }, logistics);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Logistics logistics)
        {
            if (id != logistics.Id)
            {
                return BadRequest();
            }

            _context.Entry(logistics).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var logistics = _context.Logistics.Find(id);
            if (logistics == null)
            {
                return NotFound();
            }

            _context.Logistics.Remove(logistics);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
