﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.Context;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(PontoDeInteresseContext))]
    partial class PontoDeInteresseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend.Entities.PontoDeInteresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CoordenadaX")
                        .HasColumnType("integer")
                        .HasColumnName("CoordenadaX");

                    b.Property<int>("CoordenadaY")
                        .HasColumnType("integer")
                        .HasColumnName("CoordenadaY");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Ponto-De-Interesse");
                });
#pragma warning restore 612, 618
        }
    }
}
