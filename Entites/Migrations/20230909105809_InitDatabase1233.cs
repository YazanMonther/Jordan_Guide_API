using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entites.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase1233 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "eventDateFinish",
                table: "TrendingEvents",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "eventDateFinish",
                table: "TrendingEvents");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
        }
    }
}
