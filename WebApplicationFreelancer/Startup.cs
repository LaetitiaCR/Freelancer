using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplicationFreelancer.Data;

namespace WebApplicationFreelancer
{
    public class Startup
    {

       
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();

            //services.AddIdentity<UserModel, IdentityRole>().AddEntityFrameworkStores<MyDBContextName>().AddDefaultTokenProviders();

            services.AddControllers();



            // Ajoute le support des controlleurs et du moteur de Vues Razor
            services.AddControllersWithViews();


            // r�f�rence le contexte de base de donn�es FreelancerContext
            services.AddDbContext<FreelancerContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
                
                




        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        /*
        public void ConfigureServices(IServiceCollection services)
        {

            var connectionString = "DbFreelancerConnectionString";

            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<FreelancerContext>((serviceProvider, options) =>
                    options.UseSqlServer(connectionString)
                           .UseInternalServiceProvider(serviceProvider));

   
            
            //services.AddControllers();
            //services.AddDbContext<FreelancerContext>(
            //options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection");
            


        }
        */




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();

            app.UseDefaultFiles(); // active la gestion des extensions standard
            app.UseStaticFiles(); // active la gestion des fichiers statiques stock�s dans le r�pertoire "wwwroot"

        

            // IApplicationBuilder applicationBuilder = app.UseMvc();

            app.UseRouting(); // active le routage (configuration ci-dessous)

            // ajout d'un point de terminaison HTTP
            // name = Nom de la route
            // pattern = format de l'url attendue
            //      controller : nom du contr�leur � invoquer
            //      action     : nom de la m�thode � ex�cuter dans le contr�leur invoqu�
            //      id         : valeur inject�e dans la m�thode ex�cut�e (la m�thode doit alors poss�der un argument nomm� "id")

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    
                );
            });
            

            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
            */
        }




        
        
    }
}
