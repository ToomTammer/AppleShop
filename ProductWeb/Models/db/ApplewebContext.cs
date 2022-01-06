using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProductWeb.Models.db;

namespace ProductWeb.Models.db
{
    public partial class ApplewebContext : DbContext
    {
        public ApplewebContext()
        {
        }

        public ApplewebContext(DbContextOptions<ApplewebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppleProduct> AppleProduct { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Appleweb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppleProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Apple_Product");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<ProductWeb.Models.db.Payment> Payment { get; set; }
    }
}
