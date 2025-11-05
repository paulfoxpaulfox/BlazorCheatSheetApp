using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCheatSheet.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionAddedToYogaClassType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "YogaClassTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "YogaClassTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Its Hatha");

            migrationBuilder.UpdateData(
                table: "YogaClassTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Its Vinyasa");

            migrationBuilder.UpdateData(
                table: "YogaClassTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Its Ashtanga");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "YogaClassTypes");
        }
    }
}
