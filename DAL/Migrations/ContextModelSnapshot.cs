﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Metadata.Contas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Conta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("Metadata.Ganhos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Motivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Ganhos");
                });

            modelBuilder.Entity("Metadata.Gastos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Compra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("Metadata.Saldo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Motivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RemuneracoesTotais");
                });

            modelBuilder.Entity("Metadata.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Metadata.Contas", b =>
                {
                    b.HasOne("Metadata.Usuario", "Usuario")
                        .WithMany("Contas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Metadata.Ganhos", b =>
                {
                    b.HasOne("Metadata.Usuario", "Usuario")
                        .WithMany("ganhos")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Metadata.Gastos", b =>
                {
                    b.HasOne("Metadata.Usuario", "Usuario")
                        .WithMany("Despesas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Metadata.Saldo", b =>
                {
                    b.HasOne("Metadata.Usuario", "Usuario")
                        .WithMany("saldo")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Metadata.Usuario", b =>
                {
                    b.Navigation("Contas");

                    b.Navigation("Despesas");

                    b.Navigation("ganhos");

                    b.Navigation("saldo");
                });
#pragma warning restore 612, 618
        }
    }
}
