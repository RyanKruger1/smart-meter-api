using Microsoft.EntityFrameworkCore;
using smart_meter.domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.infrasturcture.Persistence.Repositories
{
    public class ReadingsDbContext : DbContext
    {
        public ReadingsDbContext(DbContextOptions<ReadingsDbContext> options) : base(options) { }  

        public DbSet<Reading> readings { get; set; }
        Guid guid = Guid.NewGuid();
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
             base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reading>()
                .HasKey(x => x.Id);
            
            modelBuilder.Entity<Reading>()
                .HasData(
                new Reading
                {
                    Id = 1,
                    power = 0.0,
                    voltage = 0.0,
                    current = 0.0,
                    powerFactor = 0.0,
                    readingTime = DateTime.Now
                });

            modelBuilder.Entity<Reading>()
                .HasData(
                new Reading
                {
                    Id = 2,
                    power = 1,
                    voltage = 1,
                    current = 1,
                    powerFactor = 1,
                    readingTime = DateTime.Now
                });
        }
    }
}
