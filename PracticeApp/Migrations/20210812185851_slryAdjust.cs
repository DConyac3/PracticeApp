using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeApp.Migrations
{
    public partial class slryAdjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NetSalary",
                table: "Budget",
                newName: "GrossSalary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GrossSalary",
                table: "Budget",
                newName: "NetSalary");
        }
    }
}
