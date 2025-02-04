using Microsoft.EntityFrameworkCore;
using Universidad.GestionLogistica.Domain.Models;

namespace Universidad.GestionLogistica.Infrastructure.Data
{
    public class LogisticsContext : DbContext
    {
        public DbSet<Logistics> Logistics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionLogisticaDB;Trusted_Connection=True;");
        }
    }
}
