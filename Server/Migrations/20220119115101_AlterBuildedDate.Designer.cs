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
    [Migration("20220119115101_AlterBuildedDate")]
    partial class AlterBuildedDate
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BuildedDate")
                        .HasColumnType("date");

                    b.Property<string>("BuildingDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("BuildingType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasPark")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<float>("Latutude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<int?>("ManagementCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Memo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NearStation")
                        .HasColumnType("int");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("ParkDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("WalkTime")
                        .HasColumnType("int");

                    b.HasKey("BuildingId");

                    b.HasIndex("ManagementCompanyId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Construction", b =>
                {
                    b.Property<int>("ConstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConstructionId"), 1L, 1);

                    b.Property<string>("APhoto1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APhoto2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APhoto3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APhoto4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APhoto5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPhoto5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ConstructedDate")
                        .HasColumnType("date");

                    b.Property<string>("ConstructionDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConstructionFee")
                        .HasColumnType("int");

                    b.Property<string>("ConstructionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Evalution")
                        .HasColumnType("int");

                    b.Property<string>("EvalutionDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Memo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Budget")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreditCardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardSecure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exception")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuaranteeCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guarantor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuarantorAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuarantorPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Importance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthlySalary")
                        .HasColumnType("int");

                    b.Property<string>("MoveReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RenterAttributeType")
                        .HasColumnType("int");

                    b.Property<string>("RnterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RenterId");

                    b.ToTable("Renters");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Madori")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagementFee")
                        .HasColumnType("int");

                    b.Property<string>("Memo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reikin")
                        .HasColumnType("int");

                    b.Property<int>("RentFee")
                        .HasColumnType("int");

                    b.Property<string>("RoomDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("RoomStatus")
                        .HasColumnType("tinyint");

                    b.Property<string>("RoomTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Shikikin")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RoomId");

                    b.HasIndex("BuildingId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ChintaiApp.Shared.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"), 1L, 1);

                    b.Property<int>("AssumptionPayment")
                        .HasColumnType("int");

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("Commission")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadlineDate")
                        .HasColumnType("date");

                    b.Property<string>("Memo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<int>("RealPayment")
                        .HasColumnType("int");

                    b.Property<int?>("RenterId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ServicedDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("UpdatedAt")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Address")
                        .HasColumnType("int");

                    b.Property<string>("Bank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
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
