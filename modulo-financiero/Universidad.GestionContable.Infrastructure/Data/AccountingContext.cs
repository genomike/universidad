using Microsoft.EntityFrameworkCore;
using Universidad.GestionContable.Domain.Models;

namespace Universidad.GestionContable.Infrastructure.Data
{
    public class AccountingContext : DbContext
    {
        public DbSet<Accounting> Accountings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
    }
}
