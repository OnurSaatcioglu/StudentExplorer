using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentExplorer.Migrations
{
    public partial class StudentClassaddings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurnameName",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurnameName",
                table: "Students");
        }
    }
}
