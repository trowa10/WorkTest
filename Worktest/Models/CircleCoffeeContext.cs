using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Worktest.Models
{
    public partial class CircleCoffeeContext : DbContext
    {
        string _strDBConnection = "Server=DESKTOP-H4M9MPL\\SQLEXPRESS;Database=CircleCoffee;User Id = sa; Password=200410651;Trusted_Connection=True;";
        public CircleCoffeeContext()
        {
        }

        public CircleCoffeeContext(DbContextOptions<CircleCoffeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblIngredientInventory> TblIngredientInventory { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblProductIngredientUnit> TblProductIngredientUnit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_strDBConnection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblIngredientInventory>(entity =>
            {
                entity.ToTable("tblIngredientInventory");

                entity.Property(e => e.IngredientName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("tblProduct");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblProductIngredientUnit>(entity =>
            {
                entity.ToTable("tblProductIngredientUnit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.TblProductIngredientUnit)
                    .HasForeignKey(d => d.IngredientId)
                    .HasConstraintName("FK_tblProductIngredientUnit_tblIngredientInventory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductIngredientUnit)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tblProductIngredientUnit_tblProduct");
            });
        }
    }
}
