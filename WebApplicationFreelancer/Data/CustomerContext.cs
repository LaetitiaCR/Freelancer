using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.EntityConfiguration;
using static WebApplicationFreelancer.Data.CustomercatContext;
using static WebApplicationFreelancer.Data.JobContext;

namespace WebApplicationFreelancer.Data
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CustomerEntityTypeConfiguration().Configure(modelBuilder.Entity<Customer>());
            //modelBuilder.Entity<Customer>()
            //    .Property(b => b.CustomerName).HasColumnName("Description");
        }



        
        public class Customer
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string CustomerEmail { get; set; }

            public int CustomercatId { get; set; }
            
            //public Customercats Customercats { get; set; }
            //public ICollection<Customercat> Customercats { get; set; }
            //public Job Job { get; set; }
        }
       

        
        /*
        #region Required
        public class Customer
        {
            [Column("customer_id")]
            [Key]
            public int CustomerId { get; set; }


            [Required]
            [StringLength(100, ErrorMessage = "Le nom du client ne peut excéder 100 caractères.")]
            //[MaxLength(100)]
            public string CustomerName { get; set; }

            [Required]
            //[MaxLength(255)]
            [StringLength(255, ErrorMessage = "Le mail du client ne peut excéder 255 caractères.")]
            public string CustomerEmail { get; set; }



            //model Customercat.cs et table source Customercats
            public virtual ICollection<Customercat> Customercats { get; set; }


        }
        #endregion
        */

            /*
            #region Required
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Customer>()
                    .Property(b => b.CustomerEmail)
                    .IsRequired();
            }
            #endregion
            */

        }



        
    
}
