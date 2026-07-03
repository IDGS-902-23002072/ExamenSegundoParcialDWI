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
        public virtual DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // Datos iniciales de Categoría
    List<Categoria> categoriasInit = new List<Categoria>();

    categoriasInit.Add(new Categoria
    {
        Id = 1,
        Nombre = "Romance",
        Descripcion = "Historias de amor y relaciones."
    });

    categoriasInit.Add(new Categoria
    {
        Id = 2,
        Nombre = "Fantasía",
        Descripcion = "Mundos fantásticos, magia y aventuras."
    });

    categoriasInit.Add(new Categoria
    {
        Id = 3,
        Nombre = "Literatura Clásica",
        Descripcion = "Obras reconocidas de la literatura universal."
    });

    modelBuilder.Entity<Categoria>(categoria =>
    {
        categoria.ToTable("Categoria");
        categoria.HasKey(c => c.Id);

        categoria.Property(c => c.Nombre)
                 .IsRequired()
                 .HasMaxLength(50)
                 .IsUnicode(false);

        categoria.Property(c => c.Descripcion)
                 .HasMaxLength(150)
                 .IsUnicode(false);

        categoria.HasData(categoriasInit);
    });

    // Datos iniciales de Libros
    List<Libreria> librosInit = new List<Libreria>();

    librosInit.Add(new Libreria
    {
        IdLibro = 1,
        NombreLibro = "Yo Antes de Ti",
        Descripcion = "Una emotiva historia de amor.",
        Precio = 429.00m,
        ImagURL = "/imagenes/yo-antes-de-ti.jpg",
        Autor = "Jojo Moyes",
        CategoriaId = 1
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 2,
        NombreLibro = "Bajo la Misma Estrella",
        Descripcion = "Una historia de amor inolvidable.",
        Precio = 399.00m,
        ImagURL = "/imagenes/bajo-la-misma-estrella.jpg",
        Autor = "John Green",
        CategoriaId = 1
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 3,
        NombreLibro = "El Diario de Noah",
        Descripcion = "Un romance que desafía el tiempo.",
        Precio = 450.00m,
        ImagURL = "/imagenes/el-diario-de-noah.jpg",
        Autor = "Nicholas Sparks",
        CategoriaId = 1
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 4,
        NombreLibro = "El Hobbit",
        Descripcion = "La aventura de Bilbo Bolsón.",
        Precio = 390.00m,
        ImagURL = "/imagenes/el-hobbit.jpg",
        Autor = "J. R. R. Tolkien",
        CategoriaId = 2
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 5,
        NombreLibro = "Harry Potter y la Piedra Filosofal",
        Descripcion = "El inicio de la saga de Harry Potter.",
        Precio = 450.00m,
        ImagURL = "/imagenes/harry-potter-1.jpg",
        Autor = "J. K. Rowling",
        CategoriaId = 2
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 6,
        NombreLibro = "Las Crónicas de Narnia",
        Descripcion = "Viaje al mágico mundo de Narnia.",
        Precio = 480.00m,
        ImagURL = "/imagenes/narnia.jpg",
        Autor = "C. S. Lewis",
        CategoriaId = 2
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 7,
        NombreLibro = "Don Quijote de la Mancha",
        Descripcion = "Obra maestra de Miguel de Cervantes.",
        Precio = 350.00m,
        ImagURL = "/imagenes/don-quijote.jpg",
        Autor = "Miguel de Cervantes",
        CategoriaId = 3
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 8,
        NombreLibro = "Orgullo y Prejuicio",
        Descripcion = "Clásico de Jane Austen.",
        Precio = 320.00m,
        ImagURL = "/imagenes/orgullo-prejuicio.jpg",
        Autor = "Jane Austen",
        CategoriaId = 3
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 9,
        NombreLibro = "Moby Dick",
        Descripcion = "La búsqueda de la legendaria ballena blanca.",
        Precio = 410.00m,
        ImagURL = "/imagenes/moby-dick.jpg",
        Autor = "Herman Melville",
        CategoriaId = 3
    });

    librosInit.Add(new Libreria
    {
        IdLibro = 10,
        NombreLibro = "Cien Años de Soledad",
        Descripcion = "Obra cumbre del realismo mágico.",
        Precio = 530.00m,
        ImagURL = "/imagenes/cien-anos-soledad.jpg",
        Autor = "Gabriel García Márquez",
        CategoriaId = 3
    });

    modelBuilder.Entity<Libreria>(libro =>
    {
        libro.ToTable("Libreria");

        libro.HasKey(l => l.IdLibro);

        libro.HasOne(l => l.Categoria)
             .WithMany(c => c.Librerias)
             .HasForeignKey(l => l.CategoriaId);

        libro.Property(l => l.NombreLibro)
             .IsRequired()
             .HasMaxLength(50)
             .IsUnicode(false);

        libro.Property(l => l.Descripcion)
             .HasMaxLength(150)
             .IsUnicode(false);

        libro.Property(l => l.Precio)
             .HasColumnType("decimal(18,2)");

        libro.Property(l => l.Autor)
             .HasMaxLength(100)
             .IsUnicode(false);

        libro.Property(l => l.ImagURL)
             .IsUnicode(false);

        libro.HasData(librosInit);
    });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
