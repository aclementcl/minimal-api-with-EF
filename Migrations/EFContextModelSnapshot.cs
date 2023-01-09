﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using entityFramework;

#nullable disable

namespace entityFramework.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("entityFramework.Models.House", b =>
                {
                    b.Property<Guid>("HouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseInfluence")
                        .HasColumnType("int");

                    b.Property<string>("Motto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShieldUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("HouseId");

                    b.ToTable("House", (string)null);

                    b.HasData(
                        new
                        {
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"),
                            HouseInfluence = 0,
                            Motto = "Winter is Comming",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Stark"
                        },
                        new
                        {
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"),
                            HouseInfluence = 0,
                            Motto = "Fire and Blood",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Targaryen"
                        });
                });

            modelBuilder.Entity("entityFramework.Models.Person", b =>
                {
                    b.Property<Guid>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HouseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex("HouseId");

                    b.ToTable("Person", (string)null);

                    b.HasData(
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab5"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"),
                            LastName = "Snow",
                            Name = "Jon",
                            NickName = "The Winterfell bastard"
                        },
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab4"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"),
                            LastName = "Stark",
                            Name = "Eddard"
                        },
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab3"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"),
                            LastName = "Stark",
                            Name = "Robb",
                            NickName = "The young wolf"
                        },
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab2"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"),
                            LastName = "Stark",
                            Name = "Rickon"
                        },
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab1"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"),
                            LastName = "Targaryen",
                            Name = "Aegon",
                            NickName = "The Conqueror"
                        },
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ac7"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"),
                            LastName = "Targaryen",
                            Name = "Daemon"
                        },
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ac6"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"),
                            LastName = "Targaryen",
                            Name = "Baelor"
                        },
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ac5"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"),
                            LastName = "Targaryen",
                            Name = "Aenys"
                        },
                        new
                        {
                            PersonId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ac4"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"),
                            LastName = "Targaryen",
                            Name = "Maegor"
                        });
                });

            modelBuilder.Entity("entityFramework.Models.Person", b =>
                {
                    b.HasOne("entityFramework.Models.House", "House")
                        .WithMany("People")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");
                });

            modelBuilder.Entity("entityFramework.Models.House", b =>
                {
                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
