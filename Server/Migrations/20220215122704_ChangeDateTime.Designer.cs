﻿// <auto-generated />
using System;
using ChintaiApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChintaiApp.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220215122704_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChintaiApp.Shared.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Building", b =>
                {
                    b.Property<int>("BuildingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuildingId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BuildedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BuildingDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("BuildingType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("HasPark")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<float?>("Latutude")
                        .HasColumnType("real");

                    b.Property<float?>("Longitude")
                        .HasColumnType("real");

                    b.Property<int?>("ManagementCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Memo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NearStation")
                        .HasColumnType("int");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("ParkDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WalkTime")
                        .HasColumnType("int");

                    b.HasKey("BuildingId");

                    b.HasIndex("ManagementCompanyId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            BuildingId = 1,
                            BuildingDetail = "駅近です",
                            BuildingName = "集合住宅A",
                            BuildingType = (byte)1,
                            OwnerId = 2
                        });
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Construction", b =>
                {
                    b.Property<int>("ConstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConstructionId"), 1L, 1);

                    b.Property<string>("APhoto1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APhoto2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APhoto3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APhoto4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APhoto5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ConstructedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConstructionDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConstructionFee")
                        .HasColumnType("int");

                    b.Property<string>("ConstructionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Evalution")
                        .HasColumnType("int");

                    b.Property<string>("EvalutionDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Memo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ConstructionId");

                    b.HasIndex("BuildingId");

                    b.HasIndex("RoomId");

                    b.ToTable("Constructions");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Renter", b =>
                {
                    b.Property<int>("RenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RenterId"), 1L, 1);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Budget")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreditCardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardSecure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuaranteeCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guarantor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuarantorAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuarantorPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Importance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MonthlySalary")
                        .HasColumnType("int");

                    b.Property<string>("MoveReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RenterAttributeType")
                        .HasColumnType("int");

                    b.Property<string>("RenterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RenterId");

                    b.ToTable("Renters");

                    b.HasData(
                        new
                        {
                            RenterId = 1,
                            Account = "1234567890",
                            BirthDate = new DateTime(1991, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyName = "神戸製鋼",
                            Guarantor = "保証人A",
                            MonthlySalary = 30,
                            MoveReason = "職場が遠くて",
                            Phone = "1234567889",
                            RenterName = "借主A"
                        });
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Madori")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagementFee")
                        .HasColumnType("int");

                    b.Property<string>("Memo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Reikin")
                        .HasColumnType("int");

                    b.Property<int?>("RentFee")
                        .HasColumnType("int");

                    b.Property<string>("RoomDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("RoomStatus")
                        .HasColumnType("tinyint");

                    b.Property<string>("RoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Shikikin")
                        .HasColumnType("int");

                    b.Property<int?>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RoomId");

                    b.HasIndex("BuildingId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            BuildingId = 1,
                            RentFee = 63000,
                            RoomTitle = "101号室募集中"
                        },
                        new
                        {
                            RoomId = 2,
                            BuildingId = 1,
                            RentFee = 63000,
                            RoomTitle = "102号室募集中"
                        },
                        new
                        {
                            RoomId = 3,
                            BuildingId = 1,
                            RentFee = 63000,
                            RoomTitle = "103号室募集中"
                        },
                        new
                        {
                            RoomId = 4,
                            BuildingId = 1,
                            RentFee = 63000,
                            RoomTitle = "104号室募集中"
                        });
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"), 1L, 1);

                    b.Property<int?>("AssumptionPayment")
                        .HasColumnType("int");

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int?>("Commission")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeadlineDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Memo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RealPayment")
                        .HasColumnType("int");

                    b.Property<int?>("RenterId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ServicedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ServiceId");

                    b.HasIndex("BuildingId");

                    b.HasIndex("RenterId");

                    b.HasIndex("RoomId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserType")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Address = "兵庫県姫路市12345",
                            Mail = "dsadsa0@dsadsa.com",
                            Phone = "08012345567",
                            PostCode = "0000000",
                            Tel = "0981123445",
                            UserName = "システムユーザA",
                            UserType = 0
                        },
                        new
                        {
                            UserId = 2,
                            Address = "兵庫県姫路市123456",
                            Mail = "dsadsa1@dsadsa.com",
                            Phone = "08012345568",
                            PostCode = "0000000",
                            Tel = "0981123446",
                            UserName = "大家A",
                            UserType = 1
                        },
                        new
                        {
                            UserId = 3,
                            Address = "兵庫県姫路市123457",
                            Mail = "dsadsa2@dsadsa.com",
                            Phone = "08012345569",
                            PostCode = "0000000",
                            Tel = "0981123447",
                            UserName = "管理会社A",
                            UserType = 3
                        },
                        new
                        {
                            UserId = 4,
                            Address = "兵庫県姫路市123458",
                            Mail = "dsadsa3@dsadsa.com",
                            Phone = "08012345560",
                            PostCode = "0000000",
                            Tel = "0981123448",
                            UserName = "施工会社A",
                            UserType = 2
                        });
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Building", b =>
                {
                    b.HasOne("ChintaiApp.Shared.Models.User", "ManagementCompany")
                        .WithMany()
                        .HasForeignKey("ManagementCompanyId");

                    b.HasOne("ChintaiApp.Shared.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.Navigation("ManagementCompany");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Construction", b =>
                {
                    b.HasOne("ChintaiApp.Shared.Models.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId");

                    b.HasOne("ChintaiApp.Shared.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.Navigation("Building");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Room", b =>
                {
                    b.HasOne("ChintaiApp.Shared.Models.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId");

                    b.Navigation("Building");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Service", b =>
                {
                    b.HasOne("ChintaiApp.Shared.Models.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId");

                    b.HasOne("ChintaiApp.Shared.Models.Renter", "Renter")
                        .WithMany()
                        .HasForeignKey("RenterId");

                    b.HasOne("ChintaiApp.Shared.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.Navigation("Building");

                    b.Navigation("Renter");

                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
