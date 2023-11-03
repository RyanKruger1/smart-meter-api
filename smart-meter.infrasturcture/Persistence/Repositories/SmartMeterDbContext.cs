using Microsoft.EntityFrameworkCore;
using smart_meter.domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.infrasturcture.Persistence.Repositories
{
    public class SmartMeterDbContext : DbContext
    {
        public SmartMeterDbContext(DbContextOptions<SmartMeterDbContext> options) : base(options) { }  

        public DbSet<SmartMeter> meters { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SmartMeter>()
                .HasData(
                new SmartMeter
                {
                    Id = Guid.NewGuid(),
                    location = "here",
                    zipCode = "there",
                    name = "everywhere"
                });
        }
    }
}
