﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pri.Ca.Games.Infrastructure.Data;

namespace Pri.Ca.Games.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220214194322_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("GamesId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("GameGenre");

                    b.HasData(
                        new
                        {
                            GamesId = 1,
                            GenresId = 1
                        },
                        new
                        {
                            GamesId = 1,
                            GenresId = 2
                        },
                        new
                        {
                            GamesId = 1,
                            GenresId = 3
                        },
                        new
                        {
                            GamesId = 2,
                            GenresId = 1
                        },
                        new
                        {
                            GamesId = 2,
                            GenresId = 2
                        },
                        new
                        {
                            GamesId = 2,
                            GenresId = 3
                        },
                        new
                        {
                            GamesId = 3,
                            GenresId = 1
                        },
                        new
                        {
                            GamesId = 3,
                            GenresId = 2
                        },
                        new
                        {
                            GamesId = 3,
                            GenresId = 3
                        });
                });

            modelBuilder.Entity("Pri.Ca.Games.Core.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fifa2008"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Skyrim"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Halo"
                        });
                });

            modelBuilder.Entity("Pri.Ca.Games.Core.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.HasOne("Pri.Ca.Games.Core.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pri.Ca.Games.Core.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}