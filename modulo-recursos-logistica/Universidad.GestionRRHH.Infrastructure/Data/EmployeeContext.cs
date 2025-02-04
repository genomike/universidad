using Microsoft.EntityFrameworkCore;
using Universidad.GestionRRHH.Domain.Models;

namespace Universidad.GestionRRHH.Infrastructure.Data
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionRRHHDB;Trusted_Connection=True;");
        }
    }
}
