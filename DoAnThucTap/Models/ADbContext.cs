using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using static System.Reflection.Metadata.BlobBuilder;
using DoAnThucTap.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnThucTap.Models
{
    public class ADbContext : DbContext
    {
        public ADbContext(DbContextOptions<ADbContext> options) : base(options) { }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Daughihinh> daughihinhs { get; set; }
        public DbSet<Phukien> phukiens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entities and their relationships here
            modelBuilder.Entity<Camera>()
                .Property(c => c.Price)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<CartItem>()
                .Property(ci => ci.TotalAmount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasColumnType("decimal(18, 2)");
        }

    }

}
