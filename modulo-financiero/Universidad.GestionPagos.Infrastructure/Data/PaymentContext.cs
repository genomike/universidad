using Microsoft.EntityFrameworkCore;
using Universidad.GestionPagos.Domain.Models;

namespace Universidad.GestionPagos.Infrastructure.Data
{
    public class PaymentContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
    }
}
