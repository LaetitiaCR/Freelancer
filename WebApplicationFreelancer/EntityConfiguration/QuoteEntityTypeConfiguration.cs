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
                   .HasColumnName("QuoteState")
                   .HasColumnType("varchar")
                   .HasMaxLength(10)
                   .IsRequired();
            builder
               .Property(b => b.QuoteDate)
                   .HasColumnName("QuoteDate")
                   .HasColumnType("Date")
                    .HasDefaultValueSql("GetDate()")
                   .IsRequired();
            builder
               .Property(b => b.QuoteAmount)
                   .HasColumnName("QuoteAmount")
                   .HasColumnType("int")
                   .IsRequired();
            builder
               .Property(b => b.QuoteFinalDate)
                   .HasColumnName("QuoteFinalDate")
                   .HasColumnType("Date")
                    .HasDefaultValueSql("GetDate()")
                   .IsRequired();
            builder
               .Property(b => b.QuoteFinalAmount)
                   .HasColumnName("QuoteFinalAmount")
                    .HasColumnType("int")
                   .IsRequired();


    }
    }
   
}
