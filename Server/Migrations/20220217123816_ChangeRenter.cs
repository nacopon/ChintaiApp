using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChintaiApp.Server.Migrations
{
    public partial class ChangeRenter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RenterAttributeType",
                table: "Renters",
                newName: "RenterType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RenterType",
                table: "Renters",
                newName: "RenterAttributeType");
        }
    }
}
