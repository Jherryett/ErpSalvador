﻿// <auto-generated />
using System;
using ErpSalvador.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ErpSalvador.Migrations
{
    [DbContext(typeof(SystemContext))]
    [Migration("20250428182042_revisaoRh02")]
    partial class revisaoRh02
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ErpSalvador.Entities.Beneficio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descritivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeBeneficio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ValorBeneficio")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Beneficios");
                });

            modelBuilder.Entity("ErpSalvador.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescritivoDepartamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDepartamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("ErpSalvador.Entities.EnderecoFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Complemento1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeBairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeRua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCep")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EnderecoFuncionarios");
                });

            modelBuilder.Entity("ErpSalvador.Entities.Funcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescritivoFuncao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("NomeFuncao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcoes");
                });

            modelBuilder.Entity("ErpSalvador.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CpfFuncionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdBeneficio")
                        .HasColumnType("int");

                    b.Property<int?>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<int?>("IdEnderecoFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RgFuncionario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
