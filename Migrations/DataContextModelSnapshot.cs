﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalAssesmentLaBestia.Data;

#nullable disable

namespace finalAssesmentLaBestia.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Claim", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vehicle_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Vehicle_id");

                    b.ToTable("Claims");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Date = new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "the car will not start",
                            Status = "In progress",
                            Vehicleid = 1
                        },
                        new
                        {
                            id = 2,
                            Date = new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "broken window",
                            Status = "In progress",
                            Vehicleid = 2
                        },
                        new
                        {
                            id = 3,
                            Date = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "oil leakage",
                            Status = "In progress",
                            Vehicleid = 3
                        });
                });

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Owner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("DriverLicense")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id")
                        .HasName("PrimaryKey_Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DriverLicense = "123456F",
                            FirstName = "Pascual",
                            LastName = "Vera"
                        },
                        new
                        {
                            id = 2,
                            DriverLicense = "983473H",
                            FirstName = "David",
                            LastName = "Dec"
                        },
                        new
                        {
                            id = 3,
                            DriverLicense = "429384D",
                            FirstName = "Antonio",
                            LastName = "Ortiz"
                        });
                });

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Vehicle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Owner_id")
                        .HasColumnType("int");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Owner_id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Brand = "Ferrari Horse",
                            Color = "Red",
                            Ownerid = 1,
                            Vin = "48790538475F",
                            Year = 2009
                        },
                        new
                        {
                            id = 2,
                            Brand = "Ferrari Testarosa",
                            Color = "Black",
                            Ownerid = 2,
                            Vin = "58475983G",
                            Year = 2010
                        },
                        new
                        {
                            id = 3,
                            Brand = "Ferrari Purosangue",
                            Color = "Blue",
                            Ownerid = 3,
                            Vin = "45450934850K",
                            Year = 2012
                        });
                });

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Claim", b =>
                {
                    b.HasOne("finalAssesmentLaBestia.Models.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("Vehicle_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Vehicle", b =>
                {
                    b.HasOne("finalAssesmentLaBestia.Models.Owner", null)
                        .WithMany()
                        .HasForeignKey("Owner_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
