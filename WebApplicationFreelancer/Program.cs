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


        // V�rifie si la base de donn�es existe

        //Si la base de donn�es est introuvable 
        //Il est cr�� et charg� avec les donn�es de test.
        //Il charge les donn�es de test dans des tableaux plut�t que des collections List<T> afin d�optimiser les performances.

        //Si la base de donn�es est trouv�e, elle n�effectue aucune action.
        //La premi�re fois que l�application est ex�cut�e, la base de donn�es est cr��e et charg�e avec les donn�es de test.
        //Chaque fois que le mod�le de donn�es change : Supprimez la base de donn�es, Mettez � jour la m�thode Seed et recommencez avec une nouvelle base de donn�es.
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
