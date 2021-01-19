using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationConsoleEntity.Data;
using WebApplicationFreelancer.Data;

namespace WebApplicationFreelancer
{
    public class Program
    {


        // Vérifie si la base de données existe

        //Si la base de données est introuvable 
        //Il est créé et chargé avec les données de test.
        //Il charge les données de test dans des tableaux plutôt que des collections List<T> afin d’optimiser les performances.

        //Si la base de données est trouvée, elle n’effectue aucune action.
        //La première fois que l’application est exécutée, la base de données est créée et chargée avec les données de test.
        //Chaque fois que le modèle de données change : Supprimez la base de données, Mettez à jour la méthode Seed et recommencez avec une nouvelle base de données.
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();



            
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);

            host.Run();
            




        }


        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<FreelancerContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }


     
}
