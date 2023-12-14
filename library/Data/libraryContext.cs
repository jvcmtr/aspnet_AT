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
            Genero[] generos = new Genero[]{
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
            };
            
            Autor[] autores = new Autor[]{
                new Autor(){
                    Id = 1,
                    FirstName = "JRR",
                    LastName = "Tolkien",
                    birth = new DateTime(1892, 1, 3),
                    ImageFile = "JRR.jpg"
                },
                new Autor(){
                    Id = 2,
                    FirstName = "Echiro",
                    LastName = "Oda",
                    birth = new DateTime(1975, 1, 1),
                    ImageFile = "oda.jpg"
                },
                new Autor(){
                    Id = 3,
                    FirstName = "Étienne",
                    LastName = "de La Boétie",
                    birth = new DateTime(1530, 11, 1),
                    ImageFile = "default.jpg"
                }
            };
        
            modelBuilder.Entity<Genero>().HasData(generos);
            modelBuilder.Entity<Autor>().HasData(autores);

            modelBuilder.Entity<Livro>().HasData(
                new Livro()
                {
                    Id = 1,
                    ISBN = "11-11-11-11",
                    Name = "O Hobbit",
                    DataDePublicacao = new DateTime(1937, 9, 21),
                    AutorId = 1,
                    GeneroId = 3
                },
                new Livro()
                {
                    Id = 2,
                    ISBN = "Melhor quadrinho já publicado",
                    Name = "One Piece",
                    DataDePublicacao= new DateTime(1997, 7, 19),
                    AutorId = 2,
                    GeneroId = 3
                },
                new Livro()
                {
                    Id = 3,
                    ISBN = "Recomendo Fortemente",
                    Name = "Discurso sobre a servidão voluntária",
                    Sinopse = "é uma crítica à legitimidade dos governantes, chamados por ele de “tiranos”. La Boétie explica de que maneira os povos podem se submeter voluntariamente ao governo de um só homem... [Fonte Wikipedia]",
                    AutorId = 3,
                    DataDePublicacao= new DateTime(1548, 1, 1),
                    GeneroId = 10
                });
        }

    }
}
