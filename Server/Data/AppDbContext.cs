using ChintaiApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TinyHelpers.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace ChintaiApp.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Book> Books => Set<Book>();
        public DbSet<Building> Buildings => Set<Building>();
        public DbSet<Construction> Constructions => Set<Construction>();
        public DbSet<Renter> Renters => Set<Renter>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Service> Services => Set<Service>();
        public DbSet<User> Users => Set<User>();

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

            builder.Properties<DateOnly?>()
                .HaveConversion<NullableDateOnlyConverter, NullableDateOnlyComparer>()
                .HaveColumnType("date");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        // SeedData
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // 以下、seedDate
            modelBuilder.Entity<User>().HasData(
                new { UserId = 1, UserName = "システムユーザA", UserType = UserTypeEnum.SystemUser, PostCode = "0000000", Address = "兵庫県姫路市12345", Tel = "0981123445", Phone = "08012345567", Mail = "dsadsa0@dsadsa.com" },
                new { UserId = 2, UserName = "大家A", UserType = UserTypeEnum.Owner, PostCode = "0000000", Address = "兵庫県姫路市123456", Tel = "0981123446", Phone = "08012345568", Mail = "dsadsa1@dsadsa.com" },
                new { UserId = 3, UserName = "管理会社A", UserType = UserTypeEnum.ConstructionCompany, PostCode = "0000000", Address = "兵庫県姫路市123457", Tel = "0981123447", Phone = "08012345569", Mail = "dsadsa2@dsadsa.com" },
                new { UserId = 4, UserName = "施工会社A", UserType = UserTypeEnum.ManagementCompany, PostCode = "0000000", Address = "兵庫県姫路市123458", Tel = "0981123448", Phone = "08012345560", Mail = "dsadsa3@dsadsa.com" }
            );

            modelBuilder.Entity<Renter>().HasData(
                new { RenterId = 1, RenterName = "借主A", Phone = "1234567889", BirthDate = new DateTime(1991, 10, 11), CompanyName = "神戸製鋼", MonthlySalary = 30, MoveReason = "職場が遠くて", Guarantor = "保証人A", Account="1234567890" }
            );

            modelBuilder.Entity<Building>().HasData(
                new { BuildingId = 1, OwnerId = 2, BuildingName = "集合住宅A", BuildingType = BuildingTypeEnum.HousingComplex, BuildingDetail = "駅近です" }
            );

            modelBuilder.Entity<Room>().HasData(
                new { RoomId = 1, BuildingId = 1, RoomTitle = "101号室募集中", RoomStaus = 0, RentFee = 63000 },
                new { RoomId = 2, BuildingId = 1, RoomTitle = "102号室募集中", RoomStaus = 1, RentFee = 63000 },
                new { RoomId = 3, BuildingId = 1, RoomTitle = "103号室募集中", RoomStaus = 2, RentFee = 63000 },
                new { RoomId = 4, BuildingId = 1, RoomTitle = "104号室募集中", RoomStaus = 0, RentFee = 63000 }
            );
        }
    }

    /// <summary>
    /// Converts <see cref="DateOnly" /> to <see cref="DateTime"/> and vice versa.
    /// </summary>
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public DateOnlyConverter() : base(
                dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
                dateTime => DateOnly.FromDateTime(dateTime))
        { 
        }
    }
 
    /// <summary>
    /// Compares <see cref="DateOnly" />.
    /// </summary>
    public class DateOnlyComparer : ValueComparer<DateOnly>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public DateOnlyComparer() : base(
            (d1, d2) => d1 == d2 && d1.DayNumber == d2.DayNumber,
            d => d.GetHashCode()
        ){}
    }

    /// <summary>
    /// Converts <see cref="DateOnly?" /> to <see cref="DateTime?"/> and vice versa.
    /// </summary>
    public class NullableDateOnlyConverter : ValueConverter<DateOnly?, DateTime?>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public NullableDateOnlyConverter() : base(
            d => d == null
                ? null
                : new DateTime?(d.Value.ToDateTime(TimeOnly.MinValue)),
            d => d == null
                ? null
                : new DateOnly?(DateOnly.FromDateTime(d.Value))
        ){ }
    }

    /// <summary>
    /// Compares <see cref="DateOnly?" />.
    /// </summary>
    public class NullableDateOnlyComparer : ValueComparer<DateOnly?>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public NullableDateOnlyComparer() : base(
            (d1, d2) => d1 == d2 && d1.GetValueOrDefault().DayNumber == d2.GetValueOrDefault().DayNumber,
            d => d.GetHashCode()
        ){}
    }
}
