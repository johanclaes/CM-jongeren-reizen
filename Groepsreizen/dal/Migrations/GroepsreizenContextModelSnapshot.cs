﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dal;

#nullable disable

namespace dal.Migrations
{
    [DbContext(typeof(GroepsreizenContext))]
    partial class GroepsreizenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("models.Bestemming", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BestemmingstypeId")
                        .HasColumnType("int");

                    b.Property<int>("Capaciteit")
                        .HasColumnType("int");

                    b.Property<string>("Fotonaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BestemmingstypeId");

                    b.ToTable("Bestemmingen");
                });

            modelBuilder.Entity("models.Bestemmingstype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bestemmingstypes");
                });

            modelBuilder.Entity("models.Gebruiker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Allergie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Hoofdmonitorbrevet")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLid")
                        .HasColumnType("bit");

                    b.Property<string>("Medicatie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Monitorbrevet")
                        .HasColumnType("bit");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opmerking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Paswoord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Rolstoel")
                        .HasColumnType("bit");

                    b.Property<string>("Telefoonnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Webadmin")
                        .HasColumnType("bit");

                    b.Property<string>("Woonplaats")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gebruikers");
                });

            modelBuilder.Entity("models.GebruikerOpleiding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Einddatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int");

                    b.Property<int>("OpleidingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Startdatum")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GebruikerId");

                    b.HasIndex("OpleidingId");

                    b.ToTable("GebruikerOpleidingen");
                });

            modelBuilder.Entity("models.Groepsreis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BestemmingId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Deelneemprijs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Einddatum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("InschrijvingGestopt")
                        .HasColumnType("bit");

                    b.Property<int>("Maximumleeftijd")
                        .HasColumnType("int");

                    b.Property<int>("Minimumleeftijd")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OverschotBudget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("PlaatsenVrij")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Startdatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Thema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BestemmingId");

                    b.ToTable("Groepsreizen");
                });

            modelBuilder.Entity("models.Inschrijving", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Betaald")
                        .HasColumnType("bit");

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int");

                    b.Property<int>("GroepsreisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GebruikerId");

                    b.HasIndex("GroepsreisId");

                    b.ToTable("Inschrijvingen");
                });

            modelBuilder.Entity("models.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int");

                    b.Property<int>("GroepsreisId")
                        .HasColumnType("int");

                    b.Property<bool>("Hoofdmonitor")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GebruikerId");

                    b.HasIndex("GroepsreisId");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("models.Opleiding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Opleidingen");
                });

            modelBuilder.Entity("models.Bestemming", b =>
                {
                    b.HasOne("models.Bestemmingstype", "Bestemmingstype")
                        .WithMany("Bestemmingen")
                        .HasForeignKey("BestemmingstypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bestemmingstype");
                });

            modelBuilder.Entity("models.GebruikerOpleiding", b =>
                {
                    b.HasOne("models.Gebruiker", "Gebruiker")
                        .WithMany("GebruikerOpleidingen")
                        .HasForeignKey("GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("models.Opleiding", "Opleiding")
                        .WithMany("GebruikerOpleidingen")
                        .HasForeignKey("OpleidingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gebruiker");

                    b.Navigation("Opleiding");
                });

            modelBuilder.Entity("models.Groepsreis", b =>
                {
                    b.HasOne("models.Bestemming", "Bestemming")
                        .WithMany("Groepsreizen")
                        .HasForeignKey("BestemmingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bestemming");
                });

            modelBuilder.Entity("models.Inschrijving", b =>
                {
                    b.HasOne("models.Gebruiker", "Gebruiker")
                        .WithMany("Inschrijvingen")
                        .HasForeignKey("GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("models.Groepsreis", "Groepsreis")
                        .WithMany("Inschrijvingen")
                        .HasForeignKey("GroepsreisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gebruiker");

                    b.Navigation("Groepsreis");
                });

            modelBuilder.Entity("models.Monitor", b =>
                {
                    b.HasOne("models.Gebruiker", "Gebruiker")
                        .WithMany()
                        .HasForeignKey("GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("models.Groepsreis", "Groepsreis")
                        .WithMany("Monitoren")
                        .HasForeignKey("GroepsreisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gebruiker");

                    b.Navigation("Groepsreis");
                });

            modelBuilder.Entity("models.Bestemming", b =>
                {
                    b.Navigation("Groepsreizen");
                });

            modelBuilder.Entity("models.Bestemmingstype", b =>
                {
                    b.Navigation("Bestemmingen");
                });

            modelBuilder.Entity("models.Gebruiker", b =>
                {
                    b.Navigation("GebruikerOpleidingen");

                    b.Navigation("Inschrijvingen");
                });

            modelBuilder.Entity("models.Groepsreis", b =>
                {
                    b.Navigation("Inschrijvingen");

                    b.Navigation("Monitoren");
                });

            modelBuilder.Entity("models.Opleiding", b =>
                {
                    b.Navigation("GebruikerOpleidingen");
                });
#pragma warning restore 612, 618
        }
    }
}
