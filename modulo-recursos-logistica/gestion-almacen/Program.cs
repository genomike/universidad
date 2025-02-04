using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Universidad.GestionAlmacen.Api;
using Universidad.GestionAlmacen.Application;
using Universidad.GestionAlmacen.Domain;
using Universidad.GestionAlmacen.Infrastructure;

namespace Universidad.GestionAlmacen
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
