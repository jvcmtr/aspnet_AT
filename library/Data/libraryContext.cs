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

        public DbSet<library.Models.Autor> Autor { get; set; } = default!;

        public DbSet<library.Models.Livro>? Livro { get; set; }

        //public DbSet<library.Models.Genero>? Genero { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().HasData(
                new Autor( INFO ),
                new Autor( INFO )
                );
        }
        */
    }
}
