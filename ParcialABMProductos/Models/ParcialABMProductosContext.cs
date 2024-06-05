using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ParcialABMProductos.Models
{
    public partial class ParcialABMProductosContext : DbContext
    {
        public ParcialABMProductosContext()
        {
        }

        public ParcialABMProductosContext(DbContextOptions<ParcialABMProductosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=localhost; database=ParcialABMProductos; Trusted_Connection=True; TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Código)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripción)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Tamaño)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
