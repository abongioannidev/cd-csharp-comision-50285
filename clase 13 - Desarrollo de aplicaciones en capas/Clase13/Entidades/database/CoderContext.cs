using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Entidades.models;

namespace Entidades.database
{
    public partial class CoderContext : DbContext
    {
        public CoderContext()
        {
        }

        public CoderContext(DbContextOptions<CoderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<ProductoVendido> ProductoVendidos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Ventum> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.; Database=coderhousetest; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Producto");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Descripciones).IsUnicode(false);

                entity.Property(e => e.PrecioVenta).HasColumnType("money");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Usuario");
            });

            modelBuilder.Entity<ProductoVendido>(entity =>
            {
                entity.ToTable("ProductoVendido");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ProductoVendidos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoVendido_Producto");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.ProductoVendidos)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoVendido_Venta");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Apellido).IsUnicode(false);

                entity.Property(e => e.Contraseña).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreUsuario).IsUnicode(false);
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.Property(e => e.Comentarios).IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Venta_Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
