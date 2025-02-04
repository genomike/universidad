using Microsoft.EntityFrameworkCore;
using Universidad.GestionFinanciera.Domain.Models;

namespace Universidad.GestionFinanciera.Infrastructure.Data
{
    public class FinanceContext : DbContext
    {
        public DbSet<Finance> Finances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionFinancieraDB;Trusted_Connection=True;");
        }
    }
}
