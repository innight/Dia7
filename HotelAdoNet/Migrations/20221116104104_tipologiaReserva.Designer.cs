﻿// <auto-generated />
using System;
using HotelAdoNet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelAdoNet.Migrations
{
    [DbContext(typeof(MeuContexto))]
    [Migration("20221116104104_tipologiaReserva")]
    partial class tipologiaReserva
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelAdoNet.FotoQuarto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Imagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("QuartoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("QuartoId");

                    b.ToTable("FotosQuartos");
                });

            modelBuilder.Entity("HotelAdoNet.Quarto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AC")
                        .HasColumnType("bit");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("Piso")
                        .HasColumnType("int");

                    b.Property<int?>("TipologiaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipologiaId");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("HotelAdoNet.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TipologiaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipologiaId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("HotelAdoNet.Tipologia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipologias");
                });

            modelBuilder.Entity("HotelAdoNet.FotoQuarto", b =>
                {
                    b.HasOne("HotelAdoNet.Quarto", "Quarto")
                        .WithMany("FotoQuartos")
                        .HasForeignKey("QuartoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quarto");
                });

            modelBuilder.Entity("HotelAdoNet.Quarto", b =>
                {
                    b.HasOne("HotelAdoNet.Tipologia", "Tipologia")
                        .WithMany("Quartos")
                        .HasForeignKey("TipologiaId");

                    b.Navigation("Tipologia");
                });

            modelBuilder.Entity("HotelAdoNet.Reserva", b =>
                {
                    b.HasOne("HotelAdoNet.Tipologia", "Tipologia")
                        .WithMany("Reservas")
                        .HasForeignKey("TipologiaId");

                    b.Navigation("Tipologia");
                });

            modelBuilder.Entity("HotelAdoNet.Quarto", b =>
                {
                    b.Navigation("FotoQuartos");
                });

            modelBuilder.Entity("HotelAdoNet.Tipologia", b =>
                {
                    b.Navigation("Quartos");

                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}