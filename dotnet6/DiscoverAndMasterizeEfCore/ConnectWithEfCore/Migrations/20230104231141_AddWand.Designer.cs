﻿// <auto-generated />
using ConnectWithEfCore.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConnectWithEfCore.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20230104231141_AddWand")]
    partial class AddWand
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ConnectWithEfCore.Models.Data.Wand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Wand", (string)null);
                });

            modelBuilder.Entity("ConnectWithEfCore.Models.Data.Wizard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FavoriteWandId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FavoriteWandId");

                    b.ToTable("Wizard", (string)null);
                });

            modelBuilder.Entity("ConnectWithEfCore.Models.Data.Wizard", b =>
                {
                    b.HasOne("ConnectWithEfCore.Models.Data.Wand", "FavoriteWand")
                        .WithMany()
                        .HasForeignKey("FavoriteWandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FavoriteWand");
                });
#pragma warning restore 612, 618
        }
    }
}
