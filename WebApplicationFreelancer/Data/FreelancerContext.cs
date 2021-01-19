using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WebApplicationFreelancer.Models;

namespace WebApplicationConsoleEntity.Data
{
    public class FreelancerContext : DbContext
    {
        public FreelancerContext()
        {
        }

        public FreelancerContext(DbContextOptions<FreelancerContext> options): base(options)
        { }

        //      <TypeDuModele>  table
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Customercat> Customercats { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Quote> Quotes { get; set; }


        /*

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Job>().ToTable("Job");
            modelBuilder.Entity<Quote>().ToTable("Quote");
        }
        */

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
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BddFreelancer;Trusted_Connection=True;MultipleActiveResultSets=true");

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
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntry>();
        }
        */

    }
}
