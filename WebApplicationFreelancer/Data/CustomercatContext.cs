using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationFreelancer.EntityConfiguration;
using static WebApplicationFreelancer.Data.CustomerContext;

namespace WebApplicationFreelancer.Data
{
    public class CustomercatContext : DbContext
    {
        public DbSet<Customercat> Customercats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CustomercatEntityTypeConfiguration().Configure(modelBuilder.Entity<Customercat>());
          
            //modelBuilder.Entity<Customercat>()
              //  .Property(b => b.CustomercatName).HasColumnName("Description");
        }
        public class Customercat
        {
            public int CustomercatId { get; set; }
            public string CustomercatName { get; set; }
            public string CustomercatDescription { get; set; }

            public Customer Customer { get; set; }
        }
    }
}
