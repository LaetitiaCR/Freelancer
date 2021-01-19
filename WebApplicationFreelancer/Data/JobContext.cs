using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.EntityConfiguration;
using static WebApplicationFreelancer.Data.CustomerContext;
using static WebApplicationFreelancer.Data.QuoteContext;

namespace WebApplicationFreelancer.Data
{
    public class JobContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CustomerEntityTypeConfiguration().Configure(modelBuilder.Entity<Job>());
          
        }
        public class Job
        { 
            public int JobId { get; set; }
            public string JobState { get; set; }
            public string JobTitle { get; set; }
            public DateTime JobStart { get; set; }

            public DateTime JobEnd { get; set; }

            public string JobDescription { get; set; }


            
            public int CustomerId { get; set; }

            //public virtual ICollection<Customer> Customers { get; set; }
            //public Quote Quote { get; set; }
        }
    }
}
