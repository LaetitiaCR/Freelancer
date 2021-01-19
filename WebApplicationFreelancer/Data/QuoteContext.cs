using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.EntityConfiguration;
using static WebApplicationFreelancer.Data.JobContext;

namespace WebApplicationFreelancer.Data
{
    public class QuoteContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CustomerEntityTypeConfiguration().Configure(modelBuilder.Entity<Quote>());
           
        }
        public class Quote
        {
            public int QuoteId { get; set; }
            public string QuoteState { get; set; }
            public DateTime QuoteDate { get; set; }
            public int QuoteAmount { get; set; }
            public DateTime QuoteFinalDate { get; set; }
            public int QuoteFinalAmount { get; set; }



            public int JobId { get; set; }
            //public virtual ICollection<Job> Jobs { get; set; }
        }
    }
}
