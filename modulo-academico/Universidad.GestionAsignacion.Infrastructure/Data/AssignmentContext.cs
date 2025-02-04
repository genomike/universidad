using Microsoft.EntityFrameworkCore;
using Universidad.GestionAsignacion.Domain.Models;

namespace Universidad.GestionAsignacion.Infrastructure.Data
{
    public class AssignmentContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionAsignacionDB;Trusted_Connection=True;");
        }
    }
}
