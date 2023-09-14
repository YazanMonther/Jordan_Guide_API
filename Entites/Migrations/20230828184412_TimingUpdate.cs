using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entites.Migrations
{
    /// <inheritdoc />
    public partial class TimingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tourismTimings",
                table: "TourismPlaces",
                newName: "tourismLocationDesc");

            migrationBuilder.AddColumn<string>(
                name: "EventLocation",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EventLocationDesc",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FridayTime",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MondayTime",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaturdayTime",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SundayTime",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThursdayTime",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TuesdayTime",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WednesdayTime",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "eventRating",
                table: "TrendingEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FridayTime",
                table: "TourismPlaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MondayTime",
                table: "TourismPlaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaturdayTime",
                table: "TourismPlaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SundayTime",
                table: "TourismPlaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThursdayTime",
                table: "TourismPlaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TuesdayTime",
                table: "TourismPlaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WednesdayTime",
                table: "TourismPlaces",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventLocation",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "EventLocationDesc",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "FridayTime",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "MondayTime",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "SaturdayTime",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "SundayTime",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "ThursdayTime",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "TuesdayTime",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "WednesdayTime",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "eventRating",
                table: "TrendingEvents");

            migrationBuilder.DropColumn(
                name: "FridayTime",
                table: "TourismPlaces");

            migrationBuilder.DropColumn(
                name: "MondayTime",
                table: "TourismPlaces");

            migrationBuilder.DropColumn(
                name: "SaturdayTime",
                table: "TourismPlaces");

            migrationBuilder.DropColumn(
                name: "SundayTime",
                table: "TourismPlaces");

            migrationBuilder.DropColumn(
                name: "ThursdayTime",
                table: "TourismPlaces");

            migrationBuilder.DropColumn(
                name: "TuesdayTime",
                table: "TourismPlaces");

            migrationBuilder.DropColumn(
                name: "WednesdayTime",
                table: "TourismPlaces");

            migrationBuilder.RenameColumn(
                name: "tourismLocationDesc",
                table: "TourismPlaces",
                newName: "tourismTimings");
        }
    }
}
