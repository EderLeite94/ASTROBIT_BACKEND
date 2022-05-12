﻿// <auto-generated />
using System;
using ASTROBIT_BACKEND;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASTROBIT_BACKEND.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("ASTROBIT_BACKEND.Entidades.Moeda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("text");

                    b.Property<string>("Valor")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Moeda");
                });

            modelBuilder.Entity("ASTROBIT_BACKEND.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("USUARIO");
                });

            modelBuilder.Entity("ASTROBIT_BACKEND.Entidades.UsuarioMoeda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MoedaId")
                        .HasColumnType("int");

                    b.Property<int>("Moeda_Id")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("Usuario_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MoedaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioMoeda");
                });

            modelBuilder.Entity("ASTROBIT_BACKEND.Entidades.UsuarioMoeda", b =>
                {
                    b.HasOne("ASTROBIT_BACKEND.Entidades.Moeda", "Moeda")
                        .WithMany()
                        .HasForeignKey("MoedaId");

                    b.HasOne("ASTROBIT_BACKEND.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Moeda");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
