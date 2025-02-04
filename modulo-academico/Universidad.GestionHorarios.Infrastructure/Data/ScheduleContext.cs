using Microsoft.EntityFrameworkCore;
using Universidad.GestionHorarios.Domain.Models;

namespace Universidad.GestionHorarios.Infrastructure.Data
{
    public class ScheduleContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server;Database=GestionHorariosDB;Trusted_Connection=True;");
        }
    }
}
