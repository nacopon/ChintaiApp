using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChintaiApp.Server.Migrations
{
    public partial class InitialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Renters",
                columns: table => new
                {
                    RenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RnterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    RenterAttributeType = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlySalary = table.Column<int>(type: "int", nullable: false),
                    MoveReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guarantor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuarantorPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<int>(type: "int", nullable: false),
                    Importance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardSecure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuaranteeCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renters", x => x.RenterId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<int>(type: "int", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    ManagementCompanyId = table.Column<int>(type: "int", nullable: true),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingType = table.Column<byte>(type: "tinyint", nullable: false),
                    BuildingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BuildingDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NearStation = table.Column<int>(type: "int", nullable: false),
                    WalkTime = table.Column<int>(type: "int", nullable: false),
                    HasPark = table.Column<bool>(type: "bit", nullable: false),
                    ParkDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    Latutude = table.Column<float>(type: "real", nullable: false),
                    Photo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_Buildings_Users_ManagementCompanyId",
                        column: x => x.ManagementCompanyId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Buildings_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: true),
                    RoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    RentFee = table.Column<int>(type: "int", nullable: false),
                    ManagementFee = table.Column<int>(type: "int", nullable: false),
                    Shikikin = table.Column<int>(type: "int", nullable: false),
                    Reikin = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Madori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Room_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId");
                });

            migrationBuilder.CreateTable(
                name: "Constructions",
                columns: table => new
                {
                    ConstructionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    ConstructedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ConstructionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionFee = table.Column<int>(type: "int", nullable: false),
                    ConstructionDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evalution = table.Column<int>(type: "int", nullable: false),
                    EvalutionDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BPhoto1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BPhoto2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BPhoto3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BPhoto4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BPhoto5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APhoto1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APhoto2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APhoto3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APhoto4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APhoto5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constructions", x => x.ConstructionId);
                    table.ForeignKey(
                        name: "FK_Constructions_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId");
                    table.ForeignKey(
                        name: "FK_Constructions_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RenterId = table.Column<int>(type: "int", nullable: true),
                    BuildingId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    ServicedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DeadlineDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PaymentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AssumptionPayment = table.Column<int>(type: "int", nullable: false),
                    RealPayment = table.Column<int>(type: "int", nullable: false),
                    Commission = table.Column<int>(type: "int", nullable: false),
                    Memo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId");
                    table.ForeignKey(
                        name: "FK_Services_Renters_RenterId",
                        column: x => x.RenterId,
                        principalTable: "Renters",
                        principalColumn: "RenterId");
                    table.ForeignKey(
                        name: "FK_Services_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_ManagementCompanyId",
                table: "Buildings",
                column: "ManagementCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_OwnerId",
                table: "Buildings",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Constructions_BuildingId",
                table: "Constructions",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Constructions_RoomId",
                table: "Constructions",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_BuildingId",
                table: "Room",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_BuildingId",
                table: "Services",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_RenterId",
                table: "Services",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_RoomId",
                table: "Services",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Constructions");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Renters");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
