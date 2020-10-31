﻿// <auto-generated />
using System;
using FormularioProposta.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FormularioProposta.Migrations
{
    [DbContext(typeof(FormularioPropostaContext))]
    partial class FormularioPropostaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FormularioProposta.Models.Proposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataProposta");

                    b.Property<string>("EmailCliente")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<decimal>("ValorRenda");

                    b.Property<bool>("Visualizado");

                    b.HasKey("Id");

                    b.ToTable("Proposta");
                });
#pragma warning restore 612, 618
        }
    }
}