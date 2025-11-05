using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCheatSheet.Migrations
{
    /// <inheritdoc />
    public partial class ClassAttendanceRecordTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YogaClassAttendanceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YogaClassId = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttendeeCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YogaClassAttendanceRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YogaClassAttendanceRecords_YogaClasses_YogaClassId",
                        column: x => x.YogaClassId,
                        principalTable: "YogaClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YogaClassAttendanceRecords_YogaClassId",
                table: "YogaClassAttendanceRecords",
                column: "YogaClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YogaClassAttendanceRecords");
        }
    }
}
