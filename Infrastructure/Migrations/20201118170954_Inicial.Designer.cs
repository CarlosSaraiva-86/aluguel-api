﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20201118170954_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bairro")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("cep")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("cidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("endereco")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("uf")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Domain.Entities.Imovel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("andar")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("area")
                        .HasColumnType("int");

                    b.Property<int?>("enderecoid")
                        .HasColumnType("int");

                    b.Property<int>("numBanheiro")
                        .HasColumnType("int");

                    b.Property<int>("numQuartos")
                        .HasColumnType("int");

                    b.Property<int?>("proprietarioid")
                        .HasColumnType("int");

                    b.Property<int>("terreno")
                        .HasColumnType("int");

                    b.Property<string>("urlImagem")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("vagas")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("enderecoid");

                    b.HasIndex("proprietarioid");

                    b.ToTable("Imovel");
                });

            modelBuilder.Entity("Domain.Entities.Login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("user")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Login");

                    b.HasData(
                        new
                        {
                            id = 1,
                            password = "123",
                            user = "admin"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Proprietario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("enderecoid")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.HasIndex("enderecoid");

                    b.ToTable("Proprietario");
                });

            modelBuilder.Entity("Domain.Entities.Imovel", b =>
                {
                    b.HasOne("Domain.Entities.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoid");

                    b.HasOne("Domain.Entities.Proprietario", "proprietario")
                        .WithMany()
                        .HasForeignKey("proprietarioid");
                });

            modelBuilder.Entity("Domain.Entities.Proprietario", b =>
                {
                    b.HasOne("Domain.Entities.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoid");
                });
#pragma warning restore 612, 618
        }
    }
}
