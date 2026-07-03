using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibreriaAPI.Models
{
    public partial class LibreriaContext : DbContext
    {
        public LibreriaContext() { }
        public LibreriaContext(DbContextOptions<LibreriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Libreria> Librerias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libreria>(entity =>
            {
                entity.HasKey(e => e.IdLibro).HasName("PK__Libreria__3214EC07D9A1B0C3");
                entity.ToTable("Libreria");
                entity.Property(e => e.NombreLibro).HasColumnName("NombreLibro")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Descripcion).HasColumnName("Descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);
                entity.Property(e => e.Precio).HasColumnName("Precio").HasColumnType("decimal(18, 2)");
                entity.Property(e => e.ImagURL).HasColumnName("ImagURL")
                    .IsUnicode(false);
                entity.Property(e => e.Autor).HasColumnName("Autor")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.HasOne(d => d.Categoria)
                      .WithMany(c => c.Librerias)
                      .HasForeignKey(d => d.CategoriaId)
                      .HasConstraintName("FK__Libreria__Catego__3B75D760");

            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07A0D9B1F3");
                entity.ToTable("Categoria");
                entity.Property(e => e.Nombre).HasColumnName("Nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Descripcion).HasColumnName("Descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
