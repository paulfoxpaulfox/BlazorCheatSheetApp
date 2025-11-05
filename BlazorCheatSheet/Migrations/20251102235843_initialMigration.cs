using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCheatSheet.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YogaClassTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YogaClassTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YogaClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YogaClassTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YogaClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YogaClasses_YogaClassTypes_YogaClassTypeId",
                        column: x => x.YogaClassTypeId,
                        principalTable: "YogaClassTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "YogaClassTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hatha" },
                    { 2, "Vinyasa" },
                    { 3, "Ashtanga" }
                });

            migrationBuilder.InsertData(
                table: "YogaClasses",
                columns: new[] { "Id", "Description", "Name", "YogaClassTypeId" },
                values: new object[,]
                {
                    { 1, "A gentle Hatha yoga class to start your day.", "Morning Hatha Flow", 1 },
                    { 2, "An energetic Vinyasa class to build strength and flexibility.", "Power Vinyasa", 2 },
                    { 3, "A traditional Ashtanga yoga class following the primary series.", "Ashtanga Primary Series", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_YogaClasses_YogaClassTypeId",
                table: "YogaClasses",
                column: "YogaClassTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YogaClasses");

            migrationBuilder.DropTable(
                name: "YogaClassTypes");
        }
    }
}
