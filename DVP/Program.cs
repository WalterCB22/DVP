using DVP.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;


namespace DVP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().MigrateDatabase().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using var context = scope.ServiceProvider.GetRequiredService<Database.Database>();
                var usuario1 = new Usuario("Walter", "waltercastillo017@outlook.com");
                var usuario2 = new Usuario("Ricardo", "ricardo@outlook.com");
                var usuario3 = new Usuario("Carlos", "carlos@outlook.com");

                context.Usuarios.AddRange(new List<Usuario>() { usuario1, usuario2, usuario3 });
                context.SaveChanges();

                var ticket1 = new Ticket(usuario1.Id, true);
                var ticket2 = new Ticket(usuario1.Id, true, "hola Mundo");
                var ticket3 = new Ticket(usuario1.Id, true);

                context.Tickets.AddRange(new Ticket[] { ticket1, ticket2, ticket3 });
                context.SaveChanges();
            }
            return host;
        }
    }

}
