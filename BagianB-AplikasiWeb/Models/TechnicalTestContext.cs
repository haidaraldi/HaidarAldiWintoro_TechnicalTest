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
        public virtual DbSet<DataTransaksi> DataTransaksi { get; set; }
        public virtual DbSet<DetailProductPelanggan> DetailProductPelanggan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=KPPDB");
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

            modelBuilder.Entity<DataTransaksi>(entity =>
            {
                entity.Property(e => e.KodeTransaksi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pelanggan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tanggal).HasColumnType("date");
            });

            modelBuilder.Entity<DetailProductPelanggan>(entity =>
            {
                entity.Property(e => e.Pelanggan)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
