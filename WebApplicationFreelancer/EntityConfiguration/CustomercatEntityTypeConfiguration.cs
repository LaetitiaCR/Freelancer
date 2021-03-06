﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebApplicationFreelancer.Data.CustomercatContext;

namespace WebApplicationFreelancer.EntityConfiguration
{
    public class CustomercatEntityTypeConfiguration : IEntityTypeConfiguration<Customercat>
    {
      
        public void Configure(EntityTypeBuilder<Customercat> builder)
        {
            builder.HasKey(o => o.CustomercatId);
            builder
               .Property(b => b.CustomercatName)
                   .HasColumnName("CustomercatName")
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .IsRequired();
            builder
             .Property(b => b.CustomercatDescription)
                   .HasColumnName("CustomercatDescription")
                   .HasColumnType("varchar")
                   .IsRequired();

        }
    }
   
}
