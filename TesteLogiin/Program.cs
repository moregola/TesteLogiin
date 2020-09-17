using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TesteLogiin.Data;
using TesteLogiin.Service.Contracts;

namespace TesteLogiin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var scope = CreateHostBuilder(args).Build().Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                  
                    
                    var context = services.GetRequiredService<DataContext>();
                    context.Database.Migrate();
                    DataInsert.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }
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
