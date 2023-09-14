using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entites.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tourismTimings",
                table: "TourismPlaces",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tourismTimings",
                table: "TourismPlaces");
        }
    }
}
