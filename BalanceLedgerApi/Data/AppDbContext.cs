﻿using BalanceLedgerApi.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace BalanceLedgerApi.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Consolidation> Consolidations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

    }
}
