using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnketNet8.Migrations
{
    /// <inheritdoc />
    public partial class gender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Surveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Surveys");
        }
    }
}
