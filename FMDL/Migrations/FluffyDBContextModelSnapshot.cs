﻿// <auto-generated />
using System;
using FMDL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FMDL.Migrations
{
    [DbContext(typeof(FluffyDBContext))]
    partial class FluffyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("FMModels.Fluffymon", b =>
                {
                    b.Property<int>("FluffymonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AES")
                        .HasColumnType("integer");

                    b.Property<int>("Element")
                        .HasColumnType("integer");

                    b.Property<int>("Fluffiness")
                        .HasColumnType("integer");

                    b.Property<string>("FluffymonName")
                        .HasColumnType("text");

                    b.Property<int>("MGTR")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("FluffymonId");

                    b.HasIndex("UserId");

                    b.ToTable("Fluffymons");
                });

            modelBuilder.Entity("FMModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("UserHp")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FMModels.UserFluffymon", b =>
                {
                    b.Property<int>("UserFluffymonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FluffymonId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UserFluffymonId");

                    b.HasIndex("FluffymonId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFluffymons");
                });

            modelBuilder.Entity("FMModels.Fluffymon", b =>
                {
                    b.HasOne("FMModels.User", null)
                        .WithMany("Fluffymon")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FMModels.UserFluffymon", b =>
                {
                    b.HasOne("FMModels.Fluffymon", "Fluffymon")
                        .WithMany("UserFluffymon")
                        .HasForeignKey("FluffymonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FMModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fluffymon");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FMModels.Fluffymon", b =>
                {
                    b.Navigation("UserFluffymon");
                });

            modelBuilder.Entity("FMModels.User", b =>
                {
                    b.Navigation("Fluffymon");
                });
#pragma warning restore 612, 618
        }
    }
}
