﻿// <auto-generated />
using System;
using DataAceessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAceessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240215193855_Initial Cart Migration")]
    partial class InitialCartMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryRestaurant", b =>
                {
                    b.Property<int>("CategoriesID")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantsID")
                        .HasColumnType("int");

                    b.HasKey("CategoriesID", "RestaurantsID");

                    b.HasIndex("RestaurantsID");

                    b.ToTable("CategoryRestaurant");
                });

            modelBuilder.Entity("Models.ApplicationUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ApplicationUserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserID")
                        .IsUnique();

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Models.CartProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartProduct");
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ApplicationUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Models.Restaurant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("CategoryRestaurant", b =>
                {
                    b.HasOne("Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Restaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Cart", b =>
                {
                    b.HasOne("Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Cart")
                        .HasForeignKey("Models.Cart", "ApplicationUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Models.CartProduct", b =>
                {
                    b.HasOne("Models.Cart", null)
                        .WithMany("Products")
                        .HasForeignKey("CartID");

                    b.HasOne("Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.HasOne("Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Models.OrderProduct", b =>
                {
                    b.HasOne("Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.HasOne("Models.Restaurant", "Restaurant")
                        .WithMany("Products")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Models.ApplicationUser", b =>
                {
                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Models.Cart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Models.Restaurant", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
