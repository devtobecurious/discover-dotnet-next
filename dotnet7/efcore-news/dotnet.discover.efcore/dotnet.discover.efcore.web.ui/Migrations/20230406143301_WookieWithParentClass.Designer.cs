﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet.discover.efcore.web.ui.Models;

#nullable disable

namespace dotnet.discover.efcore.web.ui.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20230406143301_WookieWithParentClass")]
    partial class WookieWithParentClass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WeaponWookie", b =>
                {
                    b.Property<int>("WeaponsId")
                        .HasColumnType("int");

                    b.Property<int>("WookiesId")
                        .HasColumnType("int");

                    b.HasKey("WeaponsId", "WookiesId");

                    b.HasIndex("WookiesId");

                    b.ToTable("WeaponWookie");
                });

            modelBuilder.Entity("dotnet.discover.efcore.web.ui.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Weapons", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Weapon");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("dotnet.discover.efcore.web.ui.Models.Wookie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Wookie", (string)null);
                });

            modelBuilder.Entity("dotnet.discover.efcore.web.ui.Models.LightSaber", b =>
                {
                    b.HasBaseType("dotnet.discover.efcore.web.ui.Models.Weapon");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("LightSaber");
                });

            modelBuilder.Entity("WeaponWookie", b =>
                {
                    b.HasOne("dotnet.discover.efcore.web.ui.Models.Weapon", null)
                        .WithMany()
                        .HasForeignKey("WeaponsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet.discover.efcore.web.ui.Models.Wookie", null)
                        .WithMany()
                        .HasForeignKey("WookiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
