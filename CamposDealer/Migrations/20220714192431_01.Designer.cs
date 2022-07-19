﻿// <auto-generated />
using System;
using CamposDealer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CamposDealer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220714192431_01")]
    partial class _01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CamposDealer.Models.Clientes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("nmCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeDaCidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CamposDealer.Models.Produtos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("dscProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("vlrUnitario")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CamposDealer.Models.Vendas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<DateTime>("dthVenda")
                        .HasColumnType("datetime2");

                    b.Property<string>("idCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("qtdVenda")
                        .HasColumnType("int");

                    b.Property<float>("vlrTotalVenda")
                        .HasColumnType("real");

                    b.Property<float>("vlrUnitarioVenda")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}