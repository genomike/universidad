using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Universidad.GestionAlumnos.Api;
using Universidad.GestionAlumnos.Application;
using Universidad.GestionAlumnos.Domain;
using Universidad.GestionAlumnos.Infrastructure;

namespace Universidad.GestionAlumnos
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
