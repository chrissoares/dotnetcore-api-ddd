using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PersonMap : IEntityTypeConfiguration<PersonEntity>
    {
        public void Configure(EntityTypeBuilder<PersonEntity> builder)
        {
            builder.ToTable("Person");
            
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Name)
                .IsUnique();
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}
