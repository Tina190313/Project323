using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageClass",
                columns: table => new
                {
                    Photo_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CaptureDate = table.Column<DateTime>(nullable: false),
                    Geolocation = table.Column<string>(nullable: true),
                    CaptureBy = table.Column<string>(nullable: true),
                    Search = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageClass", x => x.Photo_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    ImageClassPhoto_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                    table.ForeignKey(
                        name: "FK_Tag_ImageClass_ImageClassPhoto_Id",
                        column: x => x.ImageClassPhoto_Id,
                        principalTable: "ImageClass",
                        principalColumn: "Photo_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tag_ImageClassPhoto_Id",
                table: "Tag",
                column: "ImageClassPhoto_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "ImageClass");
        }
    }
}
