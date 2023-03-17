using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Centaury.Infra.Migrations
{
    public partial class CriaçãodocampoDocumentaclasseEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Employees");
        }
    }
}
