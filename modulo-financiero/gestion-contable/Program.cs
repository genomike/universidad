using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Universidad.GestionContable.Api;
using Universidad.GestionContable.Application;
using Universidad.GestionContable.Domain;
using Universidad.GestionContable.Infrastructure;

namespace Universidad.GestionContable
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
