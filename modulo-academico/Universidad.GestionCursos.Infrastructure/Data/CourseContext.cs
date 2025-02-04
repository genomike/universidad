using Microsoft.EntityFrameworkCore;
using Universidad.GestionCursos.Domain.Models;

namespace Universidad.GestionCursos.Infrastructure.Data
{
    public class CourseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionCursosDB;Trusted_Connection=True;");
        }
    }
}
