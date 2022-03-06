﻿// <auto-generated />
using System;
using BakeryHelper.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BakeryHelper.DataAccess.Migrations
{
    [DbContext(typeof(ProductsStorageContext))]
    [Migration("20220306171436_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BakeryHelper.DataAccess.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NIP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BakeryHelper.DataAccess.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DayOfTheWeek")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BakeryHelper.DataAccess.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BakeryHelper.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BakeryHelper.DataAccess.Entities.Customer", b =>
                {
                    b.HasOne("BakeryHelper.DataAccess.Entities.Order", null)
                        .WithMany("Customers")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("BakeryHelper.DataAccess.Entities.Product", b =>
                {
                    b.HasOne("BakeryHelper.DataAccess.Entities.Customer", null)
                        .WithMany("Products")
                        .HasForeignKey("CustomerId");

                    b.HasOne("BakeryHelper.DataAccess.Entities.Order", null)
                        .WithMany("ProductsFromCustomers")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("BakeryHelper.DataAccess.Entities.Customer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BakeryHelper.DataAccess.Entities.Order", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("ProductsFromCustomers");
                });
#pragma warning restore 612, 618
        }
    }
}