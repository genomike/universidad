using Microsoft.EntityFrameworkCore;
using Universidad.GestionDocentes.Domain.Models;

namespace Universidad.GestionDocentes.Infrastructure.Data
{
    public class TeacherContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionDocentesDB;Trusted_Connection=True;");
        }
    }
}
