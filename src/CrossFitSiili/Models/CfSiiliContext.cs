using System;
using Microsoft.Data.Entity;

namespace CrossFitSiili.Models
{
    public sealed class CfSiiliContext : DbContext
    {
        public CfSiiliContext()
        {
           Database.EnsureCreated();   
        }

        public DbSet<Wod> Wods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Startup.Configuration["Data:CfSiiliContext"];
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}