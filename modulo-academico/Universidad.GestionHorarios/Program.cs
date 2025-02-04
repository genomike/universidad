using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Universidad.GestionHorarios.Api;
using Universidad.GestionHorarios.Application;
using Universidad.GestionHorarios.Domain;
using Universidad.GestionHorarios.Infrastructure;

namespace Universidad.GestionHorarios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
