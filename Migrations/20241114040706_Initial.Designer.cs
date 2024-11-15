﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReyphillDuarte_AP1_P2.DAL;

#nullable disable

namespace ReyphillDuarte_AP1_P2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241114040706_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Modelo_Detalles", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("Modelo")
                        .HasColumnType("int");

                    b.Property<int?>("Modelo_ExamenEntidadId")
                        .HasColumnType("int");

                    b.HasKey("DetalleId");

                    b.HasIndex("Modelo_ExamenEntidadId");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Modelo_Examen", b =>
                {
                    b.Property<int>("EntidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntidadId"));

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sueldo")
                        .HasColumnType("int");

                    b.HasKey("EntidadId");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Modelo_Detalles", b =>
                {
                    b.HasOne("ReyphillDuarte_AP1_P2.Models.Modelo_Examen", null)
                        .WithMany("Detalles")
                        .HasForeignKey("Modelo_ExamenEntidadId");
                });

            modelBuilder.Entity("ReyphillDuarte_AP1_P2.Models.Modelo_Examen", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
