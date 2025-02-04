using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Universidad.GestionDocentes.Api;
using Universidad.GestionDocentes.Application;
using Universidad.GestionDocentes.Domain;
using Universidad.GestionDocentes.Infrastructure;

namespace Universidad.GestionDocentes
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
