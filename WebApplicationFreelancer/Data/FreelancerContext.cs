using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.Models;

namespace WebApplicationFreelancer.Data
{
    public class FreelancerContext : DbContext
    {

        public FreelancerContext(DbContextOptions<FreelancerContext> options): base(options)
        { }

        //      <TypeDuModele>  table
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Customercat> Customercats { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Quote> Quotes { get; set; }


        /*
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // ajout d'un index unique
            // builder.Entity<Engine>().HasIndex(item => item.Puissance).IsUnique();
        }



        public FreelancerContext(DbContextOptions<FreelancerContext> options) : base(options)
        {

        }

        */

        /*

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["DbFreelancerConnectionString"].ConnectionString);
        }
        */

        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        */

    }
}
