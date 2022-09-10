﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SpaceProgram.EFCore;

#nullable disable

namespace SpaceProgram.Migrations
{
    [DbContext(typeof(EF_DataContext))]
    partial class EF_DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SpaceProgram.EFCore.SpaceObject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("SpaceSystemid")
                        .HasColumnType("integer");

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<int>("diameter")
                        .HasColumnType("integer");

                    b.Property<int>("mass")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("type")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("SpaceSystemid");

                    b.ToTable("spaceObject");
                });

            modelBuilder.Entity("SpaceProgram.EFCore.SpaceSystem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("spaceSystem");
                });

            modelBuilder.Entity("SpaceProgram.EFCore.SpaceObject", b =>
                {
                    b.HasOne("SpaceProgram.EFCore.SpaceSystem", "SpaceSystem")
                        .WithMany()
                        .HasForeignKey("SpaceSystemid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpaceSystem");
                });
#pragma warning restore 612, 618
        }
    }
}