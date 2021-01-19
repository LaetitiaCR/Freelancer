using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.Data;
using static WebApplicationFreelancer.Data.CustomerContext;

namespace WebApplicationFreelancer.EntityConfiguration
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(o => o.CustomerId);
            builder
                .Property(b => b.CustomerName)
                        .HasColumnName("CustomerName")
                        .HasColumnType("varchar")
                         .HasMaxLength(100)
                        .IsRequired();
            builder
                .Property(b => b.CustomerEmail)
                        .HasColumnName("CustomerEmail")
                        .HasColumnType("varchar")
                         .HasMaxLength(255)
                        .IsRequired();
            

        }

        internal void Configure(EntityTypeBuilder<JobContext.Job> entityTypeBuilder)
        {
            throw new NotImplementedException();
        }

        internal void Configure(EntityTypeBuilder<QuoteContext.Quote> entityTypeBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
