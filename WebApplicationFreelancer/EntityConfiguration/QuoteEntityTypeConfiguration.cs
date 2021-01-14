using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebApplicationFreelancer.Data.QuoteContext;

namespace WebApplicationFreelancer.EntityConfiguration
{
    public class QuoteEntityTypeConfiguration : IEntityTypeConfiguration<Quote>
    {
       

        public void Configure(EntityTypeBuilder<Quote> builder)
        {
            builder.HasKey(o => o.QuoteId);
            builder
               .Property(b => b.QuoteState)
                   .HasColumnName("Description")
                   .IsRequired();
            builder
               .Property(b => b.QuoteDate)
                   .HasColumnName("Description")
                   .IsRequired();
            builder
               .Property(b => b.QuoteAmount)
                   .HasColumnName("Description")
                   .IsRequired();
            builder
               .Property(b => b.QuoteFinalDate)
                   .HasColumnName("Description")
                   .IsRequired();
            builder
               .Property(b => b.QuoteFinalAmount)
                   .HasColumnName("Description")
                   .IsRequired();


    }
    }
   
}
