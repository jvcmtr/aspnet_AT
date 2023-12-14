using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using library.Models;

namespace library.Data
{
    public class libraryContext : DbContext
    {
        public libraryContext (DbContextOptions<libraryContext> options)
            : base(options)
        {
        }

        public DbSet<library.Models.Autor> Autor { get; set; } = default;

        public DbSet<library.Models.Livro> Livro { get; set; }

        public DbSet<library.Models.Genero> Genero { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>().HasData(
                new Genero() { Id = 1, Name = "Terror"},
                new Genero() { Id = 2, Name = "Ação" },
                new Genero() { Id = 3, Name = "Aventura" },
                new Genero() { Id = 4, Name = "Suspense" },
                new Genero() { Id = 5, Name = "Romance" },
                new Genero() { Id = 6, Name = "Erotico" },
                new Genero() { Id = 7, Name = "Misterio" },
                new Genero() { Id = 8, Name = "Cronica" },
                new Genero() { Id = 9, Name = "Historico" },
                new Genero() { Id = 10,Name = "Filosofia" },
                new Genero() { Id = 11,Name = "Quadrinhos" },
                new Genero() { Id = 12,Name = "Culinaria" }
                );
        }

    }
}
