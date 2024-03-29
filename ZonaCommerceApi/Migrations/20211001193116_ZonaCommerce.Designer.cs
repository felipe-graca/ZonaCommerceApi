﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZonaCommerceApi.Context;

namespace ZonaCommerceApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211001193116_ZonaCommerce")]
    partial class ZonaCommerce
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZonaCommerceApi.Cart", b =>
                {
                    b.Property<int>("idItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idProduto")
                        .HasColumnType("int");

                    b.Property<int>("quantidadeProduto")
                        .HasColumnType("int");

                    b.Property<double>("valorProduto")
                        .HasColumnType("float");

                    b.HasKey("idItem");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ZonaCommerceApi.Produto", b =>
                {
                    b.Property<int>("idProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("valorProduto")
                        .HasColumnType("float");

                    b.HasKey("idProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ZonaCommerceApi.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
