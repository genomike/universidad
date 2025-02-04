using Microsoft.EntityFrameworkCore;
using Universidad.GestionAlmacen.Domain.Models;

namespace Universidad.GestionAlmacen.Infrastructure.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionAlmacenDB;Trusted_Connection=True;");
        }
    }
}
