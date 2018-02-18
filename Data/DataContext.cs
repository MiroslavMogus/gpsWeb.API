using gpsWeb.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gpsWeb.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Coordinate>().Property(propertyExpression: p => p.Lat).HasColumnType("decimal(18,4)");
            builder.Entity<Coordinate>().Property(propertyExpression: p => p.Lng).HasColumnType("decimal(18,4)");

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Coordinate> Coordinates { get; set; }

    }
}
