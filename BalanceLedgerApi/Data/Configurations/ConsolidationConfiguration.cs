﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BalanceLedgerApi.Domain.Model;

namespace BalanceLedgerApi.Data.Configurations
{
    public class ConsolidationConfiguration : IEntityTypeConfiguration<Consolidation>
    {
        //types defined according to SQLite support
        public void Configure(EntityTypeBuilder<Consolidation> builder)
        {
            builder.ToTable("Consolidation");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Value)
                   .HasColumnType("NUMERIC")
                   .IsRequired();

            builder.Property(t => t.DateCreated)
                   .HasColumnType("TEXT")
                   .HasConversion(
                       v => v.ToString("yyyy-MM-dd HH:mm:ss"),
                       v => DateTime.Parse(v)
                   )
                   .IsRequired();
        }
    }
}
