using Microsoft.EntityFrameworkCore;
using Universidad.GestionAlumnos.Domain.Models;

namespace Universidad.GestionAlumnos.Infrastructure.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionAlumnosDB;Trusted_Connection=True;");
        }
    }
}
