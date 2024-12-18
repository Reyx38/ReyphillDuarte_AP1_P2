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

                    b.HasKey("DetallesId");

                    b.HasIndex("ComboId");

                    b.ToTable("ComboDetalles");
                });

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Articuloss", b =>
                {
                    b.Property<int>("ArticulosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticulosId"));

                    b.Property<float?>("Costo")
                        .HasColumnType("real");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Existencia")
                        .HasColumnType("int");

                    b.Property<float?>("Precio")
                        .HasColumnType("real");

                    b.HasKey("ArticulosId");

                    b.ToTable("Articulos");

                    b.HasData(
                        new
                        {
                            ArticulosId = 20,
                            Costo = 30f,
                            Descripcion = "Bocina",
                            Existencia = 20,
                            Precio = 40f
                        },
                        new
                        {
                            ArticulosId = 50,
                            Costo = 100f,
                            Descripcion = "Memoria RAM",
                            Existencia = 10,
                            Precio = 150f
                        },
                        new
                        {
                            ArticulosId = 60,
                            Costo = 80f,
                            Descripcion = "Disco duro grafica",
                            Existencia = 12,
                            Precio = 130f
                        },
                        new
                        {
                            ArticulosId = 70,
                            Costo = 30f,
                            Descripcion = "Pantalla",
                            Existencia = 20,
                            Precio = 40f
                        });
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

                    b.HasKey("ComboId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("RegistroTecnicos.Models.ComboDetalles", b =>
                {
                    b.HasOne("ReyphillDuarte_AP1_P2.Models.Combo", null)
                        .WithMany("Detalles")
                        .HasForeignKey("ComboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Combo", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
