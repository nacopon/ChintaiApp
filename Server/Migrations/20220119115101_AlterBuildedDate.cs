using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChintaiApp.Server.Migrations
{
    public partial class AlterBuildedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BuildingDate",
                table: "Buildings",
                newName: "BuildedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BuildedDate",
                table: "Buildings",
                newName: "BuildingDate");
        }
    }
}
