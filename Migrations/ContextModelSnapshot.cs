﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReyphillDuarte_AP1_P2.DAL;

#nullable disable

namespace ReyphillDuarte_AP1_P2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RegistroTecnicos.Models.ComboDetalles", b =>
                {
                    b.Property<int>("DetallesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetallesId"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("ComboId")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int?>("Producto")
                        .HasColumnType("int");

                    b.HasKey("DetallesId");

                    b.HasIndex("ComboId");

                    b.HasIndex("Producto");

                    b.ToTable("ComboDetalles");
                });

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Combo", b =>
                {
                    b.Property<int>("ComboId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComboId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Vendido")
                        .HasColumnType("bit");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("ComboId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Existencia")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 20,
                            Costo = 30.0,
                            Descripcion = "Bocina",
                            Existencia = 20,
                            Precio = 40.0
                        },
                        new
                        {
                            ProductoId = 50,
                            Costo = 100.0,
                            Descripcion = "Memoria RAM",
                            Existencia = 10,
                            Precio = 150.0
                        },
                        new
                        {
                            ProductoId = 60,
                            Costo = 80.0,
                            Descripcion = "Disco duro grafica",
                            Existencia = 12,
                            Precio = 130.0
                        },
                        new
                        {
                            ProductoId = 70,
                            Costo = 30.0,
                            Descripcion = "Pantalla",
                            Existencia = 20,
                            Precio = 40.0
                        });
                });

            modelBuilder.Entity("RegistroTecnicos.Models.ComboDetalles", b =>
                {
                    b.HasOne("ReyphillDuarte_AP1_P2.Models.Combo", null)
                        .WithMany("Detalles")
                        .HasForeignKey("ComboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReyphillDuarte_AP1_P2.Models.Producto", "Articulo")
                        .WithMany()
                        .HasForeignKey("Producto");

                    b.Navigation("Articulo");
                });

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Combo", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
