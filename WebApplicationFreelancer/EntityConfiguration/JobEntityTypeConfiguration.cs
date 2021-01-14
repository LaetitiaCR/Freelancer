using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebApplicationFreelancer.Data.JobContext;

namespace WebApplicationFreelancer.EntityConfiguration
{
    public class JobEntityTypeConfiguration : IEntityTypeConfiguration<Job>
    {
     

        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(o => o.JobId);
            builder
                .Property(b => b.JobState)
                    .HasColumnName("JobState")
                    .HasColumnType("varchar")
                     .HasMaxLength(10)
                    .IsRequired();
            builder
                .Property(b => b.JobTitle)
                    .HasColumnName("JobTitle")
                    .HasColumnType("varchar")
                     .HasMaxLength(100)
                    .IsRequired();
            builder
                .Property(b => b.JobStart)
                    .HasColumnName("JobStart")
                    .HasColumnType("Date")
                    .HasDefaultValueSql("GetDate()")
                    .IsRequired();

            

            builder
                .Property(b => b.JobEnd)
                    .HasColumnName("JobEnd")
                    .HasColumnType("Date")
                    .HasDefaultValueSql("GetDate()")
                    .IsRequired();

            builder
                .Property(b => b.JobDescription)
                    .HasColumnName("JobDescription")
                    .HasColumnType("varchar")
                    .IsRequired();

        }
    }
    
}
