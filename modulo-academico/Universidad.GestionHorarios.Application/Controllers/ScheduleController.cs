using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Universidad.GestionHorarios.Domain.Models;
using Universidad.GestionHorarios.Infrastructure.Data;

namespace Universidad.GestionHorarios.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly ScheduleContext _context;

        public ScheduleController(ScheduleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Schedule>> Get()
        {
            return _context.Schedules.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Schedule> Get(int id)
        {
            var schedule = _context.Schedules.Find(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return schedule;
        }

        [HttpPost]
        public ActionResult<Schedule> Post(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = schedule.Id }, schedule);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return BadRequest();
            }

            _context.Entry(schedule).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var schedule = _context.Schedules.Find(id);
            if (schedule == null)
            {
                return NotFound();
            }

            _context.Schedules.Remove(schedule);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
