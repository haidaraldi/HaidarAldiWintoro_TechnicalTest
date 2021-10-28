using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BagianB_AplikasiWeb.Models
{
    public partial class TechnicalTestContext : DbContext
    {
        public TechnicalTestContext()
        {
        }

        public TechnicalTestContext(DbContextOptions<TechnicalTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataPelanggan> DataPelanggan { get; set; }
        public virtual DbSet<DataProduct> DataProduct { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=DB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataPelanggan>(entity =>
            {
                entity.Property(e => e.Alamat)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoTelp)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataProduct>(entity =>
            {
                entity.Property(e => e.Deskripsi).IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
