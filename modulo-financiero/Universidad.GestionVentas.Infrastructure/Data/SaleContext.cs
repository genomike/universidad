using Microsoft.EntityFrameworkCore;
using Universidad.GestionVentas.Domain.Models;

namespace Universidad.GestionVentas.Infrastructure.Data
{
    public class SaleContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
    }
}
