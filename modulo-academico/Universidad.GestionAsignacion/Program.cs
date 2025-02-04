using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Universidad.GestionAsignacion.Api;
using Universidad.GestionAsignacion.Application;
using Universidad.GestionAsignacion.Domain;
using Universidad.GestionAsignacion.Infrastructure;

namespace Universidad.GestionAsignacion
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
