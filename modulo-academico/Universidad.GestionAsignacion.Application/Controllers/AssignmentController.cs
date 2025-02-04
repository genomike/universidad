using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Universidad.GestionAsignacion.Domain.Models;
using Universidad.GestionAsignacion.Infrastructure.Data;

namespace Universidad.GestionAsignacion.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentController : ControllerBase
    {
        private readonly AssignmentContext _context;

        public AssignmentController(AssignmentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Assignment>> Get()
        {
            return _context.Assignments.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Assignment> Get(int id)
        {
            var assignment = _context.Assignments.Find(id);
            if (assignment == null)
            {
                return NotFound();
            }
            return assignment;
        }

        [HttpPost]
        public ActionResult<Assignment> Post(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = assignment.Id }, assignment);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Assignment assignment)
        {
            if (id != assignment.Id)
            {
                return BadRequest();
            }

            _context.Entry(assignment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var assignment = _context.Assignments.Find(id);
            if (assignment == null)
            {
                return NotFound();
            }

            _context.Assignments.Remove(assignment);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
