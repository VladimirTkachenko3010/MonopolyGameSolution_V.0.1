﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonopolyWebApp.Database;

#nullable disable

namespace MonopolyWebApp.Migrations
{
    [DbContext(typeof(MonopolyDBContext))]
    partial class MonopolyDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MonopolyWebApp.Data.Rent", b =>
                {
                    b.Property<int>("RentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentID"));

                    b.Property<int>("RentBase")
                        .HasColumnType("int");

                    b.Property<int>("RentFour")
                        .HasColumnType("int");

                    b.Property<int>("RentHotel")
                        .HasColumnType("int");

                    b.Property<int>("RentOne")
                        .HasColumnType("int");

                    b.Property<int>("RentThree")
                        .HasColumnType("int");

                    b.Property<int>("RentTwo")
                        .HasColumnType("int");

                    b.HasKey("RentID");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("MonopolyWebApp.Data.Space", b =>
                {
                    b.Property<int>("SpaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpaceID"));

                    b.Property<int>("BuildingAmount")
                        .HasColumnType("int");

                    b.Property<bool>("HasProp")
                        .HasColumnType("bit");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropertyID")
                        .HasColumnType("int");

                    b.HasKey("SpaceID");

                    b.HasIndex("PropertyID");

                    b.ToTable("Spaces");
                });

            modelBuilder.Entity("MonopolyWebApp.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChanceId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("CardId");

                    b.ToTable("Card");

                    b.HasData(
                        new
                        {
                            CardId = 1,
                            Action = "advanceGo",
                            ChanceId = 0,
                            Description = "Advance to Go (collect 200$)",
                            Price = 10
                        });
                });

            modelBuilder.Entity("MonopolyWebApp.Models.Property", b =>
                {
                    b.Property<int>("PropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyID"));

                    b.Property<int>("BuildingCost")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMortagaged")
                        .HasColumnType("bit");

                    b.Property<int>("MortageValue")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("RentID")
                        .HasColumnType("int");

                    b.HasKey("PropertyID");

                    b.HasIndex("RentID");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("MonopolyWebApp.Data.Space", b =>
                {
                    b.HasOne("MonopolyWebApp.Models.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyID");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("MonopolyWebApp.Models.Property", b =>
                {
                    b.HasOne("MonopolyWebApp.Data.Rent", "Rent")
                        .WithMany()
                        .HasForeignKey("RentID");

                    b.Navigation("Rent");
                });
#pragma warning restore 612, 618
        }
    }
}