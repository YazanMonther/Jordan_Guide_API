using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entites.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "TourismPlaces",
                columns: table => new
                {
                    tourismPlaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tourismCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tourismName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tourismCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tourismDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tourismLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tourismPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tourismRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Main_Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourismPlaces", x => x.tourismPlaceId);
                });

            migrationBuilder.CreateTable(
                name: "TrendingEvents",
                columns: table => new
                {
                    eventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eventCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    eventDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrendingEvents", x => x.eventId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tourismPlaceId = table.Column<int>(type: "int", nullable: false),
                    tredndingEventsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.id);
                    table.ForeignKey(
                        name: "FK_Images_TourismPlaces_tourismPlaceId",
                        column: x => x.tourismPlaceId,
                        principalTable: "TourismPlaces",
                        principalColumn: "tourismPlaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_TrendingEvents_tredndingEventsId",
                        column: x => x.tredndingEventsId,
                        principalTable: "TrendingEvents",
                        principalColumn: "eventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_tourismPlaceId",
                table: "Images",
                column: "tourismPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_tredndingEventsId",
                table: "Images",
                column: "tredndingEventsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "TourismPlaces");

            migrationBuilder.DropTable(
                name: "TrendingEvents");
        }
    }
}
