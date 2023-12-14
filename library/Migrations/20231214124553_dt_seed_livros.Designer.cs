﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using library.Data;

#nullable disable

namespace library.Migrations
{
    [DbContext(typeof(libraryContext))]
    [Migration("20231214124553_dt_seed_livros")]
    partial class dt_seed_livros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("library.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("birth")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Autor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "JRR",
                            ImageFile = "JRR.jpg",
                            LastName = "Tolkien",
                            birth = new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Echiro",
                            ImageFile = "oda.jpg",
                            LastName = "Oda",
                            birth = new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Étienne",
                            ImageFile = "default.jpg",
                            LastName = "de La Boétie",
                            birth = new DateTime(1530, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("library.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Terror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ação"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Aventura"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Suspense"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Erotico"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Misterio"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Cronica"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Historico"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Filosofia"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Quadrinhos"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Culinaria"
                        });
                });

            modelBuilder.Entity("library.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDePublicacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinopse")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Livro");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AutorId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataDePublicacao = new DateTime(1937, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneroId = 3,
                            ISBN = "11-11-11-11",
                            Name = "O Hobbit"
                        },
                        new
                        {
                            Id = 2,
                            AutorId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataDePublicacao = new DateTime(1997, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneroId = 3,
                            ISBN = "Melhor quadrinho já publicado",
                            Name = "One Piece"
                        },
                        new
                        {
                            Id = 3,
                            AutorId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataDePublicacao = new DateTime(1548, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GeneroId = 10,
                            ISBN = "Recomendo Fortemente",
                            Name = "Discurso sobre a servidão voluntária",
                            Sinopse = "é uma crítica à legitimidade dos governantes, chamados por ele de “tiranos”. La Boétie explica de que maneira os povos podem se submeter voluntariamente ao governo de um só homem... [Fonte Wikipedia]"
                        });
                });

            modelBuilder.Entity("library.Models.Livro", b =>
                {
                    b.HasOne("library.Models.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("library.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}