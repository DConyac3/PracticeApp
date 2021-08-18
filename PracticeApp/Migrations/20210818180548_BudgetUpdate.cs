using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeApp.Migrations
{
    public partial class BudgetUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "NetSalary",
                table: "Budget",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetSalary",
                table: "Budget");
        }
    }
}
