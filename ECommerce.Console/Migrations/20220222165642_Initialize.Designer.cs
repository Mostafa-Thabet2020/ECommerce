﻿// <auto-generated />
using System;
using ECommerce.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Console.Migrations
{
    [DbContext(typeof(EcommorceDbContext))]
    [Migration("20220222165642_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECommerce.Console.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FloorNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("cityId");

                    b.HasIndex("userId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("ECommerce.Console.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("governroteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("governroteId");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("ECommerce.Console.Models.Governrote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("governrotes");
                });

            modelBuilder.Entity("ECommerce.Console.Models.Mobile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("mobiles");
                });

            modelBuilder.Entity("ECommerce.Console.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ECommerce.Console.Models.Address", b =>
                {
                    b.HasOne("ECommerce.Console.Models.City", "city")
                        .WithMany("addresses")
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.Console.Models.User", "user")
                        .WithMany("addresses")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("city");

                    b.Navigation("user");
                });

            modelBuilder.Entity("ECommerce.Console.Models.City", b =>
                {
                    b.HasOne("ECommerce.Console.Models.Governrote", "governrote")
                        .WithMany("cities")
                        .HasForeignKey("governroteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("governrote");
                });

            modelBuilder.Entity("ECommerce.Console.Models.Mobile", b =>
                {
                    b.HasOne("ECommerce.Console.Models.User", "user")
                        .WithMany("mobiles")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("ECommerce.Console.Models.City", b =>
                {
                    b.Navigation("addresses");
                });

            modelBuilder.Entity("ECommerce.Console.Models.Governrote", b =>
                {
                    b.Navigation("cities");
                });

            modelBuilder.Entity("ECommerce.Console.Models.User", b =>
                {
                    b.Navigation("addresses");

                    b.Navigation("mobiles");
                });
#pragma warning restore 612, 618
        }
    }
}
