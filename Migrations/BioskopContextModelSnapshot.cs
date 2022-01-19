﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace bioskop.Migrations
{
    [DbContext(typeof(BioskopContext))]
    partial class BioskopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Models.Bioskop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Bioskopi");
                });

            modelBuilder.Entity("Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<int?>("bioskopId")
                        .HasColumnType("int");

                    b.Property<DateTime>("datumKraja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("zanr")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("bioskopId");

                    b.ToTable("Filmovi");
                });

            modelBuilder.Entity("Models.Karta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("korisnikId")
                        .HasColumnType("int");

                    b.Property<int?>("projekcijaId")
                        .HasColumnType("int");

                    b.Property<int?>("sedisteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("korisnikId");

                    b.HasIndex("projekcijaId");

                    b.HasIndex("sedisteId");

                    b.ToTable("Karte");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("admin")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Models.Projekcija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("filmId")
                        .HasColumnType("int");

                    b.Property<int?>("salaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("vreme")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("filmId");

                    b.HasIndex("salaId");

                    b.ToTable("Projkecije");
                });

            modelBuilder.Entity("Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrRedova")
                        .HasColumnType("int");

                    b.Property<int>("BrSedistaPoRedu")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("bioskopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bioskopId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("Models.Sediste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrReda")
                        .HasColumnType("int");

                    b.Property<int>("BrSedistaURedu")
                        .HasColumnType("int");

                    b.Property<int?>("salaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("salaId");

                    b.ToTable("Sedista");
                });

            modelBuilder.Entity("Models.Film", b =>
                {
                    b.HasOne("Models.Bioskop", "bioskop")
                        .WithMany()
                        .HasForeignKey("bioskopId");

                    b.Navigation("bioskop");
                });

            modelBuilder.Entity("Models.Karta", b =>
                {
                    b.HasOne("Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikId");

                    b.HasOne("Models.Projekcija", "projekcija")
                        .WithMany()
                        .HasForeignKey("projekcijaId");

                    b.HasOne("Models.Sediste", "sediste")
                        .WithMany()
                        .HasForeignKey("sedisteId");

                    b.Navigation("korisnik");

                    b.Navigation("projekcija");

                    b.Navigation("sediste");
                });

            modelBuilder.Entity("Models.Projekcija", b =>
                {
                    b.HasOne("Models.Film", "film")
                        .WithMany()
                        .HasForeignKey("filmId");

                    b.HasOne("Models.Sala", "sala")
                        .WithMany()
                        .HasForeignKey("salaId");

                    b.Navigation("film");

                    b.Navigation("sala");
                });

            modelBuilder.Entity("Models.Sala", b =>
                {
                    b.HasOne("Models.Bioskop", "bioskop")
                        .WithMany()
                        .HasForeignKey("bioskopId");

                    b.Navigation("bioskop");
                });

            modelBuilder.Entity("Models.Sediste", b =>
                {
                    b.HasOne("Models.Sala", "sala")
                        .WithMany()
                        .HasForeignKey("salaId");

                    b.Navigation("sala");
                });
#pragma warning restore 612, 618
        }
    }
}