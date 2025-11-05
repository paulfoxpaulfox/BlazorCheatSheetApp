using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCheatSheet.Migrations
{
    /// <inheritdoc />
    public partial class WhatsThisChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "YogaClassAttendanceRecords",
                columns: new[] { "Id", "AttendanceDate", "AttendeeCount", "YogaClassId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 2, 7, 13, 17, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 2, new DateTime(2024, 1, 3, 14, 26, 34, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 3, new DateTime(2024, 1, 4, 21, 39, 51, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 4, new DateTime(2024, 1, 5, 4, 52, 8, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 5, new DateTime(2024, 1, 6, 11, 5, 25, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 6, new DateTime(2024, 1, 7, 18, 18, 42, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 7, new DateTime(2024, 1, 8, 1, 31, 59, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 8, new DateTime(2024, 1, 9, 8, 44, 16, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 9, new DateTime(2024, 1, 10, 15, 57, 33, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 10, new DateTime(2024, 1, 11, 22, 10, 50, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 11, new DateTime(2024, 1, 12, 5, 23, 7, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 12, new DateTime(2024, 1, 13, 12, 36, 24, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 13, new DateTime(2024, 1, 14, 19, 49, 41, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 14, new DateTime(2024, 1, 15, 2, 2, 58, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 15, new DateTime(2024, 1, 16, 9, 15, 15, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 16, new DateTime(2024, 1, 17, 16, 28, 32, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 17, new DateTime(2024, 1, 18, 23, 41, 49, 0, DateTimeKind.Unspecified), 22, 3 },
                    { 18, new DateTime(2024, 1, 19, 6, 54, 6, 0, DateTimeKind.Unspecified), 23, 1 },
                    { 19, new DateTime(2024, 1, 20, 13, 7, 23, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 20, new DateTime(2024, 1, 21, 20, 20, 40, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 21, new DateTime(2024, 1, 22, 3, 33, 57, 0, DateTimeKind.Unspecified), 26, 1 },
                    { 22, new DateTime(2024, 1, 23, 10, 46, 14, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 23, new DateTime(2024, 1, 24, 17, 59, 31, 0, DateTimeKind.Unspecified), 28, 3 },
                    { 24, new DateTime(2024, 1, 25, 0, 12, 48, 0, DateTimeKind.Unspecified), 29, 1 },
                    { 25, new DateTime(2024, 1, 26, 7, 25, 5, 0, DateTimeKind.Unspecified), 30, 2 },
                    { 26, new DateTime(2024, 1, 27, 14, 38, 22, 0, DateTimeKind.Unspecified), 31, 3 },
                    { 27, new DateTime(2024, 1, 28, 21, 51, 39, 0, DateTimeKind.Unspecified), 32, 1 },
                    { 28, new DateTime(2024, 1, 29, 4, 4, 56, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 29, new DateTime(2024, 1, 30, 11, 17, 13, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 30, new DateTime(2024, 1, 31, 18, 30, 30, 0, DateTimeKind.Unspecified), 35, 1 },
                    { 31, new DateTime(2024, 2, 1, 1, 43, 47, 0, DateTimeKind.Unspecified), 36, 2 },
                    { 32, new DateTime(2024, 2, 2, 8, 56, 4, 0, DateTimeKind.Unspecified), 37, 3 },
                    { 33, new DateTime(2024, 2, 3, 15, 9, 21, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 34, new DateTime(2024, 2, 4, 22, 22, 38, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 35, new DateTime(2024, 2, 5, 5, 35, 55, 0, DateTimeKind.Unspecified), 40, 3 },
                    { 36, new DateTime(2024, 2, 6, 12, 48, 12, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 37, new DateTime(2024, 2, 7, 19, 1, 29, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 38, new DateTime(2024, 2, 8, 2, 14, 46, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 39, new DateTime(2024, 2, 9, 9, 27, 3, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 40, new DateTime(2024, 2, 10, 16, 40, 20, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 41, new DateTime(2024, 2, 11, 23, 53, 37, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 42, new DateTime(2024, 2, 12, 6, 6, 54, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 43, new DateTime(2024, 2, 13, 13, 19, 11, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 44, new DateTime(2024, 2, 14, 20, 32, 28, 0, DateTimeKind.Unspecified), 49, 3 },
                    { 45, new DateTime(2024, 2, 15, 3, 45, 45, 0, DateTimeKind.Unspecified), 50, 1 },
                    { 46, new DateTime(2024, 2, 16, 10, 58, 2, 0, DateTimeKind.Unspecified), 51, 2 },
                    { 47, new DateTime(2024, 2, 17, 17, 11, 19, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 48, new DateTime(2024, 2, 18, 0, 24, 36, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 49, new DateTime(2024, 2, 19, 7, 37, 53, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 50, new DateTime(2024, 2, 20, 14, 50, 10, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 51, new DateTime(2024, 2, 21, 21, 3, 27, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 52, new DateTime(2024, 2, 22, 4, 16, 44, 0, DateTimeKind.Unspecified), 10, 2 },
                    { 53, new DateTime(2024, 2, 23, 11, 29, 1, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 54, new DateTime(2024, 2, 24, 18, 42, 18, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 55, new DateTime(2024, 2, 25, 1, 55, 35, 0, DateTimeKind.Unspecified), 13, 2 },
                    { 56, new DateTime(2024, 2, 26, 8, 8, 52, 0, DateTimeKind.Unspecified), 14, 3 },
                    { 57, new DateTime(2024, 2, 27, 15, 21, 9, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 58, new DateTime(2024, 2, 28, 22, 34, 26, 0, DateTimeKind.Unspecified), 16, 2 },
                    { 59, new DateTime(2024, 2, 29, 5, 47, 43, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 60, new DateTime(2024, 3, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 61, new DateTime(2024, 3, 2, 19, 13, 17, 0, DateTimeKind.Unspecified), 19, 2 },
                    { 62, new DateTime(2024, 3, 3, 2, 26, 34, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 63, new DateTime(2024, 3, 4, 9, 39, 51, 0, DateTimeKind.Unspecified), 21, 1 },
                    { 64, new DateTime(2024, 3, 5, 16, 52, 8, 0, DateTimeKind.Unspecified), 22, 2 },
                    { 65, new DateTime(2024, 3, 6, 23, 5, 25, 0, DateTimeKind.Unspecified), 23, 3 },
                    { 66, new DateTime(2024, 3, 7, 6, 18, 42, 0, DateTimeKind.Unspecified), 24, 1 },
                    { 67, new DateTime(2024, 3, 8, 13, 31, 59, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 68, new DateTime(2024, 3, 9, 20, 44, 16, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 69, new DateTime(2024, 3, 10, 3, 57, 33, 0, DateTimeKind.Unspecified), 27, 1 },
                    { 70, new DateTime(2024, 3, 11, 10, 10, 50, 0, DateTimeKind.Unspecified), 28, 2 },
                    { 71, new DateTime(2024, 3, 12, 17, 23, 7, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 72, new DateTime(2024, 3, 13, 0, 36, 24, 0, DateTimeKind.Unspecified), 30, 1 },
                    { 73, new DateTime(2024, 3, 14, 7, 49, 41, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 74, new DateTime(2024, 3, 15, 14, 2, 58, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 75, new DateTime(2024, 3, 16, 21, 15, 15, 0, DateTimeKind.Unspecified), 33, 1 },
                    { 76, new DateTime(2024, 3, 17, 4, 28, 32, 0, DateTimeKind.Unspecified), 34, 2 },
                    { 77, new DateTime(2024, 3, 18, 11, 41, 49, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 78, new DateTime(2024, 3, 19, 18, 54, 6, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 79, new DateTime(2024, 3, 20, 1, 7, 23, 0, DateTimeKind.Unspecified), 37, 2 },
                    { 80, new DateTime(2024, 3, 21, 8, 20, 40, 0, DateTimeKind.Unspecified), 38, 3 },
                    { 81, new DateTime(2024, 3, 22, 15, 33, 57, 0, DateTimeKind.Unspecified), 39, 1 },
                    { 82, new DateTime(2024, 3, 23, 22, 46, 14, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 83, new DateTime(2024, 3, 24, 5, 59, 31, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 84, new DateTime(2024, 3, 25, 12, 12, 48, 0, DateTimeKind.Unspecified), 42, 1 },
                    { 85, new DateTime(2024, 3, 26, 19, 25, 5, 0, DateTimeKind.Unspecified), 43, 2 },
                    { 86, new DateTime(2024, 3, 27, 2, 38, 22, 0, DateTimeKind.Unspecified), 44, 3 },
                    { 87, new DateTime(2024, 3, 28, 9, 51, 39, 0, DateTimeKind.Unspecified), 45, 1 },
                    { 88, new DateTime(2024, 3, 29, 16, 4, 56, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 89, new DateTime(2024, 3, 30, 23, 17, 13, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 90, new DateTime(2024, 3, 31, 6, 30, 30, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 91, new DateTime(2024, 4, 1, 13, 43, 47, 0, DateTimeKind.Unspecified), 49, 2 },
                    { 92, new DateTime(2024, 4, 2, 20, 56, 4, 0, DateTimeKind.Unspecified), 50, 3 },
                    { 93, new DateTime(2024, 4, 3, 3, 9, 21, 0, DateTimeKind.Unspecified), 51, 1 },
                    { 94, new DateTime(2024, 4, 4, 10, 22, 38, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 95, new DateTime(2024, 4, 5, 17, 35, 55, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 96, new DateTime(2024, 4, 6, 0, 48, 12, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 97, new DateTime(2024, 4, 7, 7, 1, 29, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 98, new DateTime(2024, 4, 8, 14, 14, 46, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 99, new DateTime(2024, 4, 9, 21, 27, 3, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 100, new DateTime(2024, 4, 10, 4, 40, 20, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 101, new DateTime(2024, 4, 11, 11, 53, 37, 0, DateTimeKind.Unspecified), 12, 3 },
                    { 102, new DateTime(2024, 4, 12, 18, 6, 54, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 103, new DateTime(2024, 4, 13, 1, 19, 11, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 104, new DateTime(2024, 4, 14, 8, 32, 28, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 105, new DateTime(2024, 4, 15, 15, 45, 45, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 106, new DateTime(2024, 4, 16, 22, 58, 2, 0, DateTimeKind.Unspecified), 17, 2 },
                    { 107, new DateTime(2024, 4, 17, 5, 11, 19, 0, DateTimeKind.Unspecified), 18, 3 },
                    { 108, new DateTime(2024, 4, 18, 12, 24, 36, 0, DateTimeKind.Unspecified), 19, 1 },
                    { 109, new DateTime(2024, 4, 19, 19, 37, 53, 0, DateTimeKind.Unspecified), 20, 2 },
                    { 110, new DateTime(2024, 4, 20, 2, 50, 10, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 111, new DateTime(2024, 4, 21, 9, 3, 27, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 112, new DateTime(2024, 4, 22, 16, 16, 44, 0, DateTimeKind.Unspecified), 23, 2 },
                    { 113, new DateTime(2024, 4, 23, 23, 29, 1, 0, DateTimeKind.Unspecified), 24, 3 },
                    { 114, new DateTime(2024, 4, 24, 6, 42, 18, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 115, new DateTime(2024, 4, 25, 13, 55, 35, 0, DateTimeKind.Unspecified), 26, 2 },
                    { 116, new DateTime(2024, 4, 26, 20, 8, 52, 0, DateTimeKind.Unspecified), 27, 3 },
                    { 117, new DateTime(2024, 4, 27, 3, 21, 9, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 118, new DateTime(2024, 4, 28, 10, 34, 26, 0, DateTimeKind.Unspecified), 29, 2 },
                    { 119, new DateTime(2024, 4, 29, 17, 47, 43, 0, DateTimeKind.Unspecified), 30, 3 },
                    { 120, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 1 },
                    { 121, new DateTime(2024, 5, 1, 7, 13, 17, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 122, new DateTime(2024, 5, 2, 14, 26, 34, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 123, new DateTime(2024, 5, 3, 21, 39, 51, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 124, new DateTime(2024, 5, 4, 4, 52, 8, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 125, new DateTime(2024, 5, 5, 11, 5, 25, 0, DateTimeKind.Unspecified), 36, 3 },
                    { 126, new DateTime(2024, 5, 6, 18, 18, 42, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 127, new DateTime(2024, 5, 7, 1, 31, 59, 0, DateTimeKind.Unspecified), 38, 2 },
                    { 128, new DateTime(2024, 5, 8, 8, 44, 16, 0, DateTimeKind.Unspecified), 39, 3 },
                    { 129, new DateTime(2024, 5, 9, 15, 57, 33, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 130, new DateTime(2024, 5, 10, 22, 10, 50, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 131, new DateTime(2024, 5, 11, 5, 23, 7, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 132, new DateTime(2024, 5, 12, 12, 36, 24, 0, DateTimeKind.Unspecified), 43, 1 },
                    { 133, new DateTime(2024, 5, 13, 19, 49, 41, 0, DateTimeKind.Unspecified), 44, 2 },
                    { 134, new DateTime(2024, 5, 14, 2, 2, 58, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 135, new DateTime(2024, 5, 15, 9, 15, 15, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 136, new DateTime(2024, 5, 16, 16, 28, 32, 0, DateTimeKind.Unspecified), 47, 2 },
                    { 137, new DateTime(2024, 5, 17, 23, 41, 49, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 138, new DateTime(2024, 5, 18, 6, 54, 6, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 139, new DateTime(2024, 5, 19, 13, 7, 23, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 140, new DateTime(2024, 5, 20, 20, 20, 40, 0, DateTimeKind.Unspecified), 51, 3 },
                    { 141, new DateTime(2024, 5, 21, 3, 33, 57, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 142, new DateTime(2024, 5, 22, 10, 46, 14, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 143, new DateTime(2024, 5, 23, 17, 59, 31, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 144, new DateTime(2024, 5, 24, 0, 12, 48, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 145, new DateTime(2024, 5, 25, 7, 25, 5, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 146, new DateTime(2024, 5, 26, 14, 38, 22, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 147, new DateTime(2024, 5, 27, 21, 51, 39, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 148, new DateTime(2024, 5, 28, 4, 4, 56, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 149, new DateTime(2024, 5, 29, 11, 17, 13, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 150, new DateTime(2024, 5, 30, 18, 30, 30, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 151, new DateTime(2024, 5, 31, 1, 43, 47, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 152, new DateTime(2024, 6, 1, 8, 56, 4, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 153, new DateTime(2024, 6, 2, 15, 9, 21, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 154, new DateTime(2024, 6, 3, 22, 22, 38, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 155, new DateTime(2024, 6, 4, 5, 35, 55, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 156, new DateTime(2024, 6, 5, 12, 48, 12, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 157, new DateTime(2024, 6, 6, 19, 1, 29, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 158, new DateTime(2024, 6, 7, 2, 14, 46, 0, DateTimeKind.Unspecified), 22, 3 },
                    { 159, new DateTime(2024, 6, 8, 9, 27, 3, 0, DateTimeKind.Unspecified), 23, 1 },
                    { 160, new DateTime(2024, 6, 9, 16, 40, 20, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 161, new DateTime(2024, 6, 10, 23, 53, 37, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 162, new DateTime(2024, 6, 11, 6, 6, 54, 0, DateTimeKind.Unspecified), 26, 1 },
                    { 163, new DateTime(2024, 6, 12, 13, 19, 11, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 164, new DateTime(2024, 6, 13, 20, 32, 28, 0, DateTimeKind.Unspecified), 28, 3 },
                    { 165, new DateTime(2024, 6, 14, 3, 45, 45, 0, DateTimeKind.Unspecified), 29, 1 },
                    { 166, new DateTime(2024, 6, 15, 10, 58, 2, 0, DateTimeKind.Unspecified), 30, 2 },
                    { 167, new DateTime(2024, 6, 16, 17, 11, 19, 0, DateTimeKind.Unspecified), 31, 3 },
                    { 168, new DateTime(2024, 6, 17, 0, 24, 36, 0, DateTimeKind.Unspecified), 32, 1 },
                    { 169, new DateTime(2024, 6, 18, 7, 37, 53, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 170, new DateTime(2024, 6, 19, 14, 50, 10, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 171, new DateTime(2024, 6, 20, 21, 3, 27, 0, DateTimeKind.Unspecified), 35, 1 },
                    { 172, new DateTime(2024, 6, 21, 4, 16, 44, 0, DateTimeKind.Unspecified), 36, 2 },
                    { 173, new DateTime(2024, 6, 22, 11, 29, 1, 0, DateTimeKind.Unspecified), 37, 3 },
                    { 174, new DateTime(2024, 6, 23, 18, 42, 18, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 175, new DateTime(2024, 6, 24, 1, 55, 35, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 176, new DateTime(2024, 6, 25, 8, 8, 52, 0, DateTimeKind.Unspecified), 40, 3 },
                    { 177, new DateTime(2024, 6, 26, 15, 21, 9, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 178, new DateTime(2024, 6, 27, 22, 34, 26, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 179, new DateTime(2024, 6, 28, 5, 47, 43, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 180, new DateTime(2024, 6, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 181, new DateTime(2024, 6, 30, 19, 13, 17, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 182, new DateTime(2024, 7, 1, 2, 26, 34, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 183, new DateTime(2024, 7, 2, 9, 39, 51, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 184, new DateTime(2024, 7, 3, 16, 52, 8, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 185, new DateTime(2024, 7, 4, 23, 5, 25, 0, DateTimeKind.Unspecified), 49, 3 },
                    { 186, new DateTime(2024, 7, 5, 6, 18, 42, 0, DateTimeKind.Unspecified), 50, 1 },
                    { 187, new DateTime(2024, 7, 6, 13, 31, 59, 0, DateTimeKind.Unspecified), 51, 2 },
                    { 188, new DateTime(2024, 7, 7, 20, 44, 16, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 189, new DateTime(2024, 7, 8, 3, 57, 33, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 190, new DateTime(2024, 7, 9, 10, 10, 50, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 191, new DateTime(2024, 7, 10, 17, 23, 7, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 192, new DateTime(2024, 7, 11, 0, 36, 24, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 193, new DateTime(2024, 7, 12, 7, 49, 41, 0, DateTimeKind.Unspecified), 10, 2 },
                    { 194, new DateTime(2024, 7, 13, 14, 2, 58, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 195, new DateTime(2024, 7, 14, 21, 15, 15, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 196, new DateTime(2024, 7, 15, 4, 28, 32, 0, DateTimeKind.Unspecified), 13, 2 },
                    { 197, new DateTime(2024, 7, 16, 11, 41, 49, 0, DateTimeKind.Unspecified), 14, 3 },
                    { 198, new DateTime(2024, 7, 17, 18, 54, 6, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 199, new DateTime(2024, 7, 18, 1, 7, 23, 0, DateTimeKind.Unspecified), 16, 2 },
                    { 200, new DateTime(2024, 7, 19, 8, 20, 40, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 201, new DateTime(2024, 7, 20, 15, 33, 57, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 202, new DateTime(2024, 7, 21, 22, 46, 14, 0, DateTimeKind.Unspecified), 19, 2 },
                    { 203, new DateTime(2024, 7, 22, 5, 59, 31, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 204, new DateTime(2024, 7, 23, 12, 12, 48, 0, DateTimeKind.Unspecified), 21, 1 },
                    { 205, new DateTime(2024, 7, 24, 19, 25, 5, 0, DateTimeKind.Unspecified), 22, 2 },
                    { 206, new DateTime(2024, 7, 25, 2, 38, 22, 0, DateTimeKind.Unspecified), 23, 3 },
                    { 207, new DateTime(2024, 7, 26, 9, 51, 39, 0, DateTimeKind.Unspecified), 24, 1 },
                    { 208, new DateTime(2024, 7, 27, 16, 4, 56, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 209, new DateTime(2024, 7, 28, 23, 17, 13, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 210, new DateTime(2024, 7, 29, 6, 30, 30, 0, DateTimeKind.Unspecified), 27, 1 },
                    { 211, new DateTime(2024, 7, 30, 13, 43, 47, 0, DateTimeKind.Unspecified), 28, 2 },
                    { 212, new DateTime(2024, 7, 31, 20, 56, 4, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 213, new DateTime(2024, 8, 1, 3, 9, 21, 0, DateTimeKind.Unspecified), 30, 1 },
                    { 214, new DateTime(2024, 8, 2, 10, 22, 38, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 215, new DateTime(2024, 8, 3, 17, 35, 55, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 216, new DateTime(2024, 8, 4, 0, 48, 12, 0, DateTimeKind.Unspecified), 33, 1 },
                    { 217, new DateTime(2024, 8, 5, 7, 1, 29, 0, DateTimeKind.Unspecified), 34, 2 },
                    { 218, new DateTime(2024, 8, 6, 14, 14, 46, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 219, new DateTime(2024, 8, 7, 21, 27, 3, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 220, new DateTime(2024, 8, 8, 4, 40, 20, 0, DateTimeKind.Unspecified), 37, 2 },
                    { 221, new DateTime(2024, 8, 9, 11, 53, 37, 0, DateTimeKind.Unspecified), 38, 3 },
                    { 222, new DateTime(2024, 8, 10, 18, 6, 54, 0, DateTimeKind.Unspecified), 39, 1 },
                    { 223, new DateTime(2024, 8, 11, 1, 19, 11, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 224, new DateTime(2024, 8, 12, 8, 32, 28, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 225, new DateTime(2024, 8, 13, 15, 45, 45, 0, DateTimeKind.Unspecified), 42, 1 },
                    { 226, new DateTime(2024, 8, 14, 22, 58, 2, 0, DateTimeKind.Unspecified), 43, 2 },
                    { 227, new DateTime(2024, 8, 15, 5, 11, 19, 0, DateTimeKind.Unspecified), 44, 3 },
                    { 228, new DateTime(2024, 8, 16, 12, 24, 36, 0, DateTimeKind.Unspecified), 45, 1 },
                    { 229, new DateTime(2024, 8, 17, 19, 37, 53, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 230, new DateTime(2024, 8, 18, 2, 50, 10, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 231, new DateTime(2024, 8, 19, 9, 3, 27, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 232, new DateTime(2024, 8, 20, 16, 16, 44, 0, DateTimeKind.Unspecified), 49, 2 },
                    { 233, new DateTime(2024, 8, 21, 23, 29, 1, 0, DateTimeKind.Unspecified), 50, 3 },
                    { 234, new DateTime(2024, 8, 22, 6, 42, 18, 0, DateTimeKind.Unspecified), 51, 1 },
                    { 235, new DateTime(2024, 8, 23, 13, 55, 35, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 236, new DateTime(2024, 8, 24, 20, 8, 52, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 237, new DateTime(2024, 8, 25, 3, 21, 9, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 238, new DateTime(2024, 8, 26, 10, 34, 26, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 239, new DateTime(2024, 8, 27, 17, 47, 43, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 240, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 241, new DateTime(2024, 8, 29, 7, 13, 17, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 242, new DateTime(2024, 8, 30, 14, 26, 34, 0, DateTimeKind.Unspecified), 12, 3 },
                    { 243, new DateTime(2024, 8, 31, 21, 39, 51, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 244, new DateTime(2024, 9, 1, 4, 52, 8, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 245, new DateTime(2024, 9, 2, 11, 5, 25, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 246, new DateTime(2024, 9, 3, 18, 18, 42, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 247, new DateTime(2024, 9, 4, 1, 31, 59, 0, DateTimeKind.Unspecified), 17, 2 },
                    { 248, new DateTime(2024, 9, 5, 8, 44, 16, 0, DateTimeKind.Unspecified), 18, 3 },
                    { 249, new DateTime(2024, 9, 6, 15, 57, 33, 0, DateTimeKind.Unspecified), 19, 1 },
                    { 250, new DateTime(2024, 9, 7, 22, 10, 50, 0, DateTimeKind.Unspecified), 20, 2 },
                    { 251, new DateTime(2024, 9, 8, 5, 23, 7, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 252, new DateTime(2024, 9, 9, 12, 36, 24, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 253, new DateTime(2024, 9, 10, 19, 49, 41, 0, DateTimeKind.Unspecified), 23, 2 },
                    { 254, new DateTime(2024, 9, 11, 2, 2, 58, 0, DateTimeKind.Unspecified), 24, 3 },
                    { 255, new DateTime(2024, 9, 12, 9, 15, 15, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 256, new DateTime(2024, 9, 13, 16, 28, 32, 0, DateTimeKind.Unspecified), 26, 2 },
                    { 257, new DateTime(2024, 9, 14, 23, 41, 49, 0, DateTimeKind.Unspecified), 27, 3 },
                    { 258, new DateTime(2024, 9, 15, 6, 54, 6, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 259, new DateTime(2024, 9, 16, 13, 7, 23, 0, DateTimeKind.Unspecified), 29, 2 },
                    { 260, new DateTime(2024, 9, 17, 20, 20, 40, 0, DateTimeKind.Unspecified), 30, 3 },
                    { 261, new DateTime(2024, 9, 18, 3, 33, 57, 0, DateTimeKind.Unspecified), 31, 1 },
                    { 262, new DateTime(2024, 9, 19, 10, 46, 14, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 263, new DateTime(2024, 9, 20, 17, 59, 31, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 264, new DateTime(2024, 9, 21, 0, 12, 48, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 265, new DateTime(2024, 9, 22, 7, 25, 5, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 266, new DateTime(2024, 9, 23, 14, 38, 22, 0, DateTimeKind.Unspecified), 36, 3 },
                    { 267, new DateTime(2024, 9, 24, 21, 51, 39, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 268, new DateTime(2024, 9, 25, 4, 4, 56, 0, DateTimeKind.Unspecified), 38, 2 },
                    { 269, new DateTime(2024, 9, 26, 11, 17, 13, 0, DateTimeKind.Unspecified), 39, 3 },
                    { 270, new DateTime(2024, 9, 27, 18, 30, 30, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 271, new DateTime(2024, 9, 28, 1, 43, 47, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 272, new DateTime(2024, 9, 29, 8, 56, 4, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 273, new DateTime(2024, 9, 30, 15, 9, 21, 0, DateTimeKind.Unspecified), 43, 1 },
                    { 274, new DateTime(2024, 10, 1, 22, 22, 38, 0, DateTimeKind.Unspecified), 44, 2 },
                    { 275, new DateTime(2024, 10, 2, 5, 35, 55, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 276, new DateTime(2024, 10, 3, 12, 48, 12, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 277, new DateTime(2024, 10, 4, 19, 1, 29, 0, DateTimeKind.Unspecified), 47, 2 },
                    { 278, new DateTime(2024, 10, 5, 2, 14, 46, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 279, new DateTime(2024, 10, 6, 9, 27, 3, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 280, new DateTime(2024, 10, 7, 16, 40, 20, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 281, new DateTime(2024, 10, 8, 23, 53, 37, 0, DateTimeKind.Unspecified), 51, 3 },
                    { 282, new DateTime(2024, 10, 9, 6, 6, 54, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 283, new DateTime(2024, 10, 10, 13, 19, 11, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 284, new DateTime(2024, 10, 11, 20, 32, 28, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 285, new DateTime(2024, 10, 12, 3, 45, 45, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 286, new DateTime(2024, 10, 13, 10, 58, 2, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 287, new DateTime(2024, 10, 14, 17, 11, 19, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 288, new DateTime(2024, 10, 15, 0, 24, 36, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 289, new DateTime(2024, 10, 16, 7, 37, 53, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 290, new DateTime(2024, 10, 17, 14, 50, 10, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 291, new DateTime(2024, 10, 18, 21, 3, 27, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 292, new DateTime(2024, 10, 19, 4, 16, 44, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 293, new DateTime(2024, 10, 20, 11, 29, 1, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 294, new DateTime(2024, 10, 21, 18, 42, 18, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 295, new DateTime(2024, 10, 22, 1, 55, 35, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 296, new DateTime(2024, 10, 23, 8, 8, 52, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 297, new DateTime(2024, 10, 24, 15, 21, 9, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 298, new DateTime(2024, 10, 25, 22, 34, 26, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 299, new DateTime(2024, 10, 26, 5, 47, 43, 0, DateTimeKind.Unspecified), 22, 3 },
                    { 300, new DateTime(2024, 10, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), 23, 1 },
                    { 301, new DateTime(2024, 10, 28, 19, 13, 17, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 302, new DateTime(2024, 10, 29, 2, 26, 34, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 303, new DateTime(2024, 10, 30, 9, 39, 51, 0, DateTimeKind.Unspecified), 26, 1 },
                    { 304, new DateTime(2024, 10, 31, 16, 52, 8, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 305, new DateTime(2024, 11, 1, 23, 5, 25, 0, DateTimeKind.Unspecified), 28, 3 },
                    { 306, new DateTime(2024, 11, 2, 6, 18, 42, 0, DateTimeKind.Unspecified), 29, 1 },
                    { 307, new DateTime(2024, 11, 3, 13, 31, 59, 0, DateTimeKind.Unspecified), 30, 2 },
                    { 308, new DateTime(2024, 11, 4, 20, 44, 16, 0, DateTimeKind.Unspecified), 31, 3 },
                    { 309, new DateTime(2024, 11, 5, 3, 57, 33, 0, DateTimeKind.Unspecified), 32, 1 },
                    { 310, new DateTime(2024, 11, 6, 10, 10, 50, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 311, new DateTime(2024, 11, 7, 17, 23, 7, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 312, new DateTime(2024, 11, 8, 0, 36, 24, 0, DateTimeKind.Unspecified), 35, 1 },
                    { 313, new DateTime(2024, 11, 9, 7, 49, 41, 0, DateTimeKind.Unspecified), 36, 2 },
                    { 314, new DateTime(2024, 11, 10, 14, 2, 58, 0, DateTimeKind.Unspecified), 37, 3 },
                    { 315, new DateTime(2024, 11, 11, 21, 15, 15, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 316, new DateTime(2024, 11, 12, 4, 28, 32, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 317, new DateTime(2024, 11, 13, 11, 41, 49, 0, DateTimeKind.Unspecified), 40, 3 },
                    { 318, new DateTime(2024, 11, 14, 18, 54, 6, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 319, new DateTime(2024, 11, 15, 1, 7, 23, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 320, new DateTime(2024, 11, 16, 8, 20, 40, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 321, new DateTime(2024, 11, 17, 15, 33, 57, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 322, new DateTime(2024, 11, 18, 22, 46, 14, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 323, new DateTime(2024, 11, 19, 5, 59, 31, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 324, new DateTime(2024, 11, 20, 12, 12, 48, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 325, new DateTime(2024, 11, 21, 19, 25, 5, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 326, new DateTime(2024, 11, 22, 2, 38, 22, 0, DateTimeKind.Unspecified), 49, 3 },
                    { 327, new DateTime(2024, 11, 23, 9, 51, 39, 0, DateTimeKind.Unspecified), 50, 1 },
                    { 328, new DateTime(2024, 11, 24, 16, 4, 56, 0, DateTimeKind.Unspecified), 51, 2 },
                    { 329, new DateTime(2024, 11, 25, 23, 17, 13, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 330, new DateTime(2024, 11, 26, 6, 30, 30, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 331, new DateTime(2024, 11, 27, 13, 43, 47, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 332, new DateTime(2024, 11, 28, 20, 56, 4, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 333, new DateTime(2024, 11, 29, 3, 9, 21, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 334, new DateTime(2024, 11, 30, 10, 22, 38, 0, DateTimeKind.Unspecified), 10, 2 },
                    { 335, new DateTime(2024, 12, 1, 17, 35, 55, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 336, new DateTime(2024, 12, 2, 0, 48, 12, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 337, new DateTime(2024, 12, 3, 7, 1, 29, 0, DateTimeKind.Unspecified), 13, 2 },
                    { 338, new DateTime(2024, 12, 4, 14, 14, 46, 0, DateTimeKind.Unspecified), 14, 3 },
                    { 339, new DateTime(2024, 12, 5, 21, 27, 3, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 340, new DateTime(2024, 12, 6, 4, 40, 20, 0, DateTimeKind.Unspecified), 16, 2 },
                    { 341, new DateTime(2024, 12, 7, 11, 53, 37, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 342, new DateTime(2024, 12, 8, 18, 6, 54, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 343, new DateTime(2024, 12, 9, 1, 19, 11, 0, DateTimeKind.Unspecified), 19, 2 },
                    { 344, new DateTime(2024, 12, 10, 8, 32, 28, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 345, new DateTime(2024, 12, 11, 15, 45, 45, 0, DateTimeKind.Unspecified), 21, 1 },
                    { 346, new DateTime(2024, 12, 12, 22, 58, 2, 0, DateTimeKind.Unspecified), 22, 2 },
                    { 347, new DateTime(2024, 12, 13, 5, 11, 19, 0, DateTimeKind.Unspecified), 23, 3 },
                    { 348, new DateTime(2024, 12, 14, 12, 24, 36, 0, DateTimeKind.Unspecified), 24, 1 },
                    { 349, new DateTime(2024, 12, 15, 19, 37, 53, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 350, new DateTime(2024, 12, 16, 2, 50, 10, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 351, new DateTime(2024, 12, 17, 9, 3, 27, 0, DateTimeKind.Unspecified), 27, 1 },
                    { 352, new DateTime(2024, 12, 18, 16, 16, 44, 0, DateTimeKind.Unspecified), 28, 2 },
                    { 353, new DateTime(2024, 12, 19, 23, 29, 1, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 354, new DateTime(2024, 12, 20, 6, 42, 18, 0, DateTimeKind.Unspecified), 30, 1 },
                    { 355, new DateTime(2024, 12, 21, 13, 55, 35, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 356, new DateTime(2024, 12, 22, 20, 8, 52, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 357, new DateTime(2024, 12, 23, 3, 21, 9, 0, DateTimeKind.Unspecified), 33, 1 },
                    { 358, new DateTime(2024, 12, 24, 10, 34, 26, 0, DateTimeKind.Unspecified), 34, 2 },
                    { 359, new DateTime(2024, 12, 25, 17, 47, 43, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 360, new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 361, new DateTime(2024, 12, 27, 7, 13, 17, 0, DateTimeKind.Unspecified), 37, 2 },
                    { 362, new DateTime(2024, 12, 28, 14, 26, 34, 0, DateTimeKind.Unspecified), 38, 3 },
                    { 363, new DateTime(2024, 12, 29, 21, 39, 51, 0, DateTimeKind.Unspecified), 39, 1 },
                    { 364, new DateTime(2024, 12, 30, 4, 52, 8, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 365, new DateTime(2024, 1, 1, 11, 5, 25, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 366, new DateTime(2024, 1, 2, 18, 18, 42, 0, DateTimeKind.Unspecified), 42, 1 },
                    { 367, new DateTime(2024, 1, 3, 1, 31, 59, 0, DateTimeKind.Unspecified), 43, 2 },
                    { 368, new DateTime(2024, 1, 4, 8, 44, 16, 0, DateTimeKind.Unspecified), 44, 3 },
                    { 369, new DateTime(2024, 1, 5, 15, 57, 33, 0, DateTimeKind.Unspecified), 45, 1 },
                    { 370, new DateTime(2024, 1, 6, 22, 10, 50, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 371, new DateTime(2024, 1, 7, 5, 23, 7, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 372, new DateTime(2024, 1, 8, 12, 36, 24, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 373, new DateTime(2024, 1, 9, 19, 49, 41, 0, DateTimeKind.Unspecified), 49, 2 },
                    { 374, new DateTime(2024, 1, 10, 2, 2, 58, 0, DateTimeKind.Unspecified), 50, 3 },
                    { 375, new DateTime(2024, 1, 11, 9, 15, 15, 0, DateTimeKind.Unspecified), 51, 1 },
                    { 376, new DateTime(2024, 1, 12, 16, 28, 32, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 377, new DateTime(2024, 1, 13, 23, 41, 49, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 378, new DateTime(2024, 1, 14, 6, 54, 6, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 379, new DateTime(2024, 1, 15, 13, 7, 23, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 380, new DateTime(2024, 1, 16, 20, 20, 40, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 381, new DateTime(2024, 1, 17, 3, 33, 57, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 382, new DateTime(2024, 1, 18, 10, 46, 14, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 383, new DateTime(2024, 1, 19, 17, 59, 31, 0, DateTimeKind.Unspecified), 12, 3 },
                    { 384, new DateTime(2024, 1, 20, 0, 12, 48, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 385, new DateTime(2024, 1, 21, 7, 25, 5, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 386, new DateTime(2024, 1, 22, 14, 38, 22, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 387, new DateTime(2024, 1, 23, 21, 51, 39, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 388, new DateTime(2024, 1, 24, 4, 4, 56, 0, DateTimeKind.Unspecified), 17, 2 },
                    { 389, new DateTime(2024, 1, 25, 11, 17, 13, 0, DateTimeKind.Unspecified), 18, 3 },
                    { 390, new DateTime(2024, 1, 26, 18, 30, 30, 0, DateTimeKind.Unspecified), 19, 1 },
                    { 391, new DateTime(2024, 1, 27, 1, 43, 47, 0, DateTimeKind.Unspecified), 20, 2 },
                    { 392, new DateTime(2024, 1, 28, 8, 56, 4, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 393, new DateTime(2024, 1, 29, 15, 9, 21, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 394, new DateTime(2024, 1, 30, 22, 22, 38, 0, DateTimeKind.Unspecified), 23, 2 },
                    { 395, new DateTime(2024, 1, 31, 5, 35, 55, 0, DateTimeKind.Unspecified), 24, 3 },
                    { 396, new DateTime(2024, 2, 1, 12, 48, 12, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 397, new DateTime(2024, 2, 2, 19, 1, 29, 0, DateTimeKind.Unspecified), 26, 2 },
                    { 398, new DateTime(2024, 2, 3, 2, 14, 46, 0, DateTimeKind.Unspecified), 27, 3 },
                    { 399, new DateTime(2024, 2, 4, 9, 27, 3, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 400, new DateTime(2024, 2, 5, 16, 40, 20, 0, DateTimeKind.Unspecified), 29, 2 },
                    { 401, new DateTime(2024, 2, 6, 23, 53, 37, 0, DateTimeKind.Unspecified), 30, 3 },
                    { 402, new DateTime(2024, 2, 7, 6, 6, 54, 0, DateTimeKind.Unspecified), 31, 1 },
                    { 403, new DateTime(2024, 2, 8, 13, 19, 11, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 404, new DateTime(2024, 2, 9, 20, 32, 28, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 405, new DateTime(2024, 2, 10, 3, 45, 45, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 406, new DateTime(2024, 2, 11, 10, 58, 2, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 407, new DateTime(2024, 2, 12, 17, 11, 19, 0, DateTimeKind.Unspecified), 36, 3 },
                    { 408, new DateTime(2024, 2, 13, 0, 24, 36, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 409, new DateTime(2024, 2, 14, 7, 37, 53, 0, DateTimeKind.Unspecified), 38, 2 },
                    { 410, new DateTime(2024, 2, 15, 14, 50, 10, 0, DateTimeKind.Unspecified), 39, 3 },
                    { 411, new DateTime(2024, 2, 16, 21, 3, 27, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 412, new DateTime(2024, 2, 17, 4, 16, 44, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 413, new DateTime(2024, 2, 18, 11, 29, 1, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 414, new DateTime(2024, 2, 19, 18, 42, 18, 0, DateTimeKind.Unspecified), 43, 1 },
                    { 415, new DateTime(2024, 2, 20, 1, 55, 35, 0, DateTimeKind.Unspecified), 44, 2 },
                    { 416, new DateTime(2024, 2, 21, 8, 8, 52, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 417, new DateTime(2024, 2, 22, 15, 21, 9, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 418, new DateTime(2024, 2, 23, 22, 34, 26, 0, DateTimeKind.Unspecified), 47, 2 },
                    { 419, new DateTime(2024, 2, 24, 5, 47, 43, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 420, new DateTime(2024, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 421, new DateTime(2024, 2, 26, 19, 13, 17, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 422, new DateTime(2024, 2, 27, 2, 26, 34, 0, DateTimeKind.Unspecified), 51, 3 },
                    { 423, new DateTime(2024, 2, 28, 9, 39, 51, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 424, new DateTime(2024, 2, 29, 16, 52, 8, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 425, new DateTime(2024, 3, 1, 23, 5, 25, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 426, new DateTime(2024, 3, 2, 6, 18, 42, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 427, new DateTime(2024, 3, 3, 13, 31, 59, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 428, new DateTime(2024, 3, 4, 20, 44, 16, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 429, new DateTime(2024, 3, 5, 3, 57, 33, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 430, new DateTime(2024, 3, 6, 10, 10, 50, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 431, new DateTime(2024, 3, 7, 17, 23, 7, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 432, new DateTime(2024, 3, 8, 0, 36, 24, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 433, new DateTime(2024, 3, 9, 7, 49, 41, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 434, new DateTime(2024, 3, 10, 14, 2, 58, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 435, new DateTime(2024, 3, 11, 21, 15, 15, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 436, new DateTime(2024, 3, 12, 4, 28, 32, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 437, new DateTime(2024, 3, 13, 11, 41, 49, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 438, new DateTime(2024, 3, 14, 18, 54, 6, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 439, new DateTime(2024, 3, 15, 1, 7, 23, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 440, new DateTime(2024, 3, 16, 8, 20, 40, 0, DateTimeKind.Unspecified), 22, 3 },
                    { 441, new DateTime(2024, 3, 17, 15, 33, 57, 0, DateTimeKind.Unspecified), 23, 1 },
                    { 442, new DateTime(2024, 3, 18, 22, 46, 14, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 443, new DateTime(2024, 3, 19, 5, 59, 31, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 444, new DateTime(2024, 3, 20, 12, 12, 48, 0, DateTimeKind.Unspecified), 26, 1 },
                    { 445, new DateTime(2024, 3, 21, 19, 25, 5, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 446, new DateTime(2024, 3, 22, 2, 38, 22, 0, DateTimeKind.Unspecified), 28, 3 },
                    { 447, new DateTime(2024, 3, 23, 9, 51, 39, 0, DateTimeKind.Unspecified), 29, 1 },
                    { 448, new DateTime(2024, 3, 24, 16, 4, 56, 0, DateTimeKind.Unspecified), 30, 2 },
                    { 449, new DateTime(2024, 3, 25, 23, 17, 13, 0, DateTimeKind.Unspecified), 31, 3 },
                    { 450, new DateTime(2024, 3, 26, 6, 30, 30, 0, DateTimeKind.Unspecified), 32, 1 },
                    { 451, new DateTime(2024, 3, 27, 13, 43, 47, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 452, new DateTime(2024, 3, 28, 20, 56, 4, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 453, new DateTime(2024, 3, 29, 3, 9, 21, 0, DateTimeKind.Unspecified), 35, 1 },
                    { 454, new DateTime(2024, 3, 30, 10, 22, 38, 0, DateTimeKind.Unspecified), 36, 2 },
                    { 455, new DateTime(2024, 3, 31, 17, 35, 55, 0, DateTimeKind.Unspecified), 37, 3 },
                    { 456, new DateTime(2024, 4, 1, 0, 48, 12, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 457, new DateTime(2024, 4, 2, 7, 1, 29, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 458, new DateTime(2024, 4, 3, 14, 14, 46, 0, DateTimeKind.Unspecified), 40, 3 },
                    { 459, new DateTime(2024, 4, 4, 21, 27, 3, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 460, new DateTime(2024, 4, 5, 4, 40, 20, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 461, new DateTime(2024, 4, 6, 11, 53, 37, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 462, new DateTime(2024, 4, 7, 18, 6, 54, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 463, new DateTime(2024, 4, 8, 1, 19, 11, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 464, new DateTime(2024, 4, 9, 8, 32, 28, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 465, new DateTime(2024, 4, 10, 15, 45, 45, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 466, new DateTime(2024, 4, 11, 22, 58, 2, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 467, new DateTime(2024, 4, 12, 5, 11, 19, 0, DateTimeKind.Unspecified), 49, 3 },
                    { 468, new DateTime(2024, 4, 13, 12, 24, 36, 0, DateTimeKind.Unspecified), 50, 1 },
                    { 469, new DateTime(2024, 4, 14, 19, 37, 53, 0, DateTimeKind.Unspecified), 51, 2 },
                    { 470, new DateTime(2024, 4, 15, 2, 50, 10, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 471, new DateTime(2024, 4, 16, 9, 3, 27, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 472, new DateTime(2024, 4, 17, 16, 16, 44, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 473, new DateTime(2024, 4, 18, 23, 29, 1, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 474, new DateTime(2024, 4, 19, 6, 42, 18, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 475, new DateTime(2024, 4, 20, 13, 55, 35, 0, DateTimeKind.Unspecified), 10, 2 },
                    { 476, new DateTime(2024, 4, 21, 20, 8, 52, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 477, new DateTime(2024, 4, 22, 3, 21, 9, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 478, new DateTime(2024, 4, 23, 10, 34, 26, 0, DateTimeKind.Unspecified), 13, 2 },
                    { 479, new DateTime(2024, 4, 24, 17, 47, 43, 0, DateTimeKind.Unspecified), 14, 3 },
                    { 480, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 481, new DateTime(2024, 4, 26, 7, 13, 17, 0, DateTimeKind.Unspecified), 16, 2 },
                    { 482, new DateTime(2024, 4, 27, 14, 26, 34, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 483, new DateTime(2024, 4, 28, 21, 39, 51, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 484, new DateTime(2024, 4, 29, 4, 52, 8, 0, DateTimeKind.Unspecified), 19, 2 },
                    { 485, new DateTime(2024, 4, 30, 11, 5, 25, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 486, new DateTime(2024, 5, 1, 18, 18, 42, 0, DateTimeKind.Unspecified), 21, 1 },
                    { 487, new DateTime(2024, 5, 2, 1, 31, 59, 0, DateTimeKind.Unspecified), 22, 2 },
                    { 488, new DateTime(2024, 5, 3, 8, 44, 16, 0, DateTimeKind.Unspecified), 23, 3 },
                    { 489, new DateTime(2024, 5, 4, 15, 57, 33, 0, DateTimeKind.Unspecified), 24, 1 },
                    { 490, new DateTime(2024, 5, 5, 22, 10, 50, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 491, new DateTime(2024, 5, 6, 5, 23, 7, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 492, new DateTime(2024, 5, 7, 12, 36, 24, 0, DateTimeKind.Unspecified), 27, 1 },
                    { 493, new DateTime(2024, 5, 8, 19, 49, 41, 0, DateTimeKind.Unspecified), 28, 2 },
                    { 494, new DateTime(2024, 5, 9, 2, 2, 58, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 495, new DateTime(2024, 5, 10, 9, 15, 15, 0, DateTimeKind.Unspecified), 30, 1 },
                    { 496, new DateTime(2024, 5, 11, 16, 28, 32, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 497, new DateTime(2024, 5, 12, 23, 41, 49, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 498, new DateTime(2024, 5, 13, 6, 54, 6, 0, DateTimeKind.Unspecified), 33, 1 },
                    { 499, new DateTime(2024, 5, 14, 13, 7, 23, 0, DateTimeKind.Unspecified), 34, 2 },
                    { 500, new DateTime(2024, 5, 15, 20, 20, 40, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 501, new DateTime(2024, 5, 16, 3, 33, 57, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 502, new DateTime(2024, 5, 17, 10, 46, 14, 0, DateTimeKind.Unspecified), 37, 2 },
                    { 503, new DateTime(2024, 5, 18, 17, 59, 31, 0, DateTimeKind.Unspecified), 38, 3 },
                    { 504, new DateTime(2024, 5, 19, 0, 12, 48, 0, DateTimeKind.Unspecified), 39, 1 },
                    { 505, new DateTime(2024, 5, 20, 7, 25, 5, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 506, new DateTime(2024, 5, 21, 14, 38, 22, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 507, new DateTime(2024, 5, 22, 21, 51, 39, 0, DateTimeKind.Unspecified), 42, 1 },
                    { 508, new DateTime(2024, 5, 23, 4, 4, 56, 0, DateTimeKind.Unspecified), 43, 2 },
                    { 509, new DateTime(2024, 5, 24, 11, 17, 13, 0, DateTimeKind.Unspecified), 44, 3 },
                    { 510, new DateTime(2024, 5, 25, 18, 30, 30, 0, DateTimeKind.Unspecified), 45, 1 },
                    { 511, new DateTime(2024, 5, 26, 1, 43, 47, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 512, new DateTime(2024, 5, 27, 8, 56, 4, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 513, new DateTime(2024, 5, 28, 15, 9, 21, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 514, new DateTime(2024, 5, 29, 22, 22, 38, 0, DateTimeKind.Unspecified), 49, 2 },
                    { 515, new DateTime(2024, 5, 30, 5, 35, 55, 0, DateTimeKind.Unspecified), 50, 3 },
                    { 516, new DateTime(2024, 5, 31, 12, 48, 12, 0, DateTimeKind.Unspecified), 51, 1 },
                    { 517, new DateTime(2024, 6, 1, 19, 1, 29, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 518, new DateTime(2024, 6, 2, 2, 14, 46, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 519, new DateTime(2024, 6, 3, 9, 27, 3, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 520, new DateTime(2024, 6, 4, 16, 40, 20, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 521, new DateTime(2024, 6, 5, 23, 53, 37, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 522, new DateTime(2024, 6, 6, 6, 6, 54, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 523, new DateTime(2024, 6, 7, 13, 19, 11, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 524, new DateTime(2024, 6, 8, 20, 32, 28, 0, DateTimeKind.Unspecified), 12, 3 },
                    { 525, new DateTime(2024, 6, 9, 3, 45, 45, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 526, new DateTime(2024, 6, 10, 10, 58, 2, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 527, new DateTime(2024, 6, 11, 17, 11, 19, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 528, new DateTime(2024, 6, 12, 0, 24, 36, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 529, new DateTime(2024, 6, 13, 7, 37, 53, 0, DateTimeKind.Unspecified), 17, 2 },
                    { 530, new DateTime(2024, 6, 14, 14, 50, 10, 0, DateTimeKind.Unspecified), 18, 3 },
                    { 531, new DateTime(2024, 6, 15, 21, 3, 27, 0, DateTimeKind.Unspecified), 19, 1 },
                    { 532, new DateTime(2024, 6, 16, 4, 16, 44, 0, DateTimeKind.Unspecified), 20, 2 },
                    { 533, new DateTime(2024, 6, 17, 11, 29, 1, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 534, new DateTime(2024, 6, 18, 18, 42, 18, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 535, new DateTime(2024, 6, 19, 1, 55, 35, 0, DateTimeKind.Unspecified), 23, 2 },
                    { 536, new DateTime(2024, 6, 20, 8, 8, 52, 0, DateTimeKind.Unspecified), 24, 3 },
                    { 537, new DateTime(2024, 6, 21, 15, 21, 9, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 538, new DateTime(2024, 6, 22, 22, 34, 26, 0, DateTimeKind.Unspecified), 26, 2 },
                    { 539, new DateTime(2024, 6, 23, 5, 47, 43, 0, DateTimeKind.Unspecified), 27, 3 },
                    { 540, new DateTime(2024, 6, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 541, new DateTime(2024, 6, 25, 19, 13, 17, 0, DateTimeKind.Unspecified), 29, 2 },
                    { 542, new DateTime(2024, 6, 26, 2, 26, 34, 0, DateTimeKind.Unspecified), 30, 3 },
                    { 543, new DateTime(2024, 6, 27, 9, 39, 51, 0, DateTimeKind.Unspecified), 31, 1 },
                    { 544, new DateTime(2024, 6, 28, 16, 52, 8, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 545, new DateTime(2024, 6, 29, 23, 5, 25, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 546, new DateTime(2024, 6, 30, 6, 18, 42, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 547, new DateTime(2024, 7, 1, 13, 31, 59, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 548, new DateTime(2024, 7, 2, 20, 44, 16, 0, DateTimeKind.Unspecified), 36, 3 },
                    { 549, new DateTime(2024, 7, 3, 3, 57, 33, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 550, new DateTime(2024, 7, 4, 10, 10, 50, 0, DateTimeKind.Unspecified), 38, 2 },
                    { 551, new DateTime(2024, 7, 5, 17, 23, 7, 0, DateTimeKind.Unspecified), 39, 3 },
                    { 552, new DateTime(2024, 7, 6, 0, 36, 24, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 553, new DateTime(2024, 7, 7, 7, 49, 41, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 554, new DateTime(2024, 7, 8, 14, 2, 58, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 555, new DateTime(2024, 7, 9, 21, 15, 15, 0, DateTimeKind.Unspecified), 43, 1 },
                    { 556, new DateTime(2024, 7, 10, 4, 28, 32, 0, DateTimeKind.Unspecified), 44, 2 },
                    { 557, new DateTime(2024, 7, 11, 11, 41, 49, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 558, new DateTime(2024, 7, 12, 18, 54, 6, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 559, new DateTime(2024, 7, 13, 1, 7, 23, 0, DateTimeKind.Unspecified), 47, 2 },
                    { 560, new DateTime(2024, 7, 14, 8, 20, 40, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 561, new DateTime(2024, 7, 15, 15, 33, 57, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 562, new DateTime(2024, 7, 16, 22, 46, 14, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 563, new DateTime(2024, 7, 17, 5, 59, 31, 0, DateTimeKind.Unspecified), 51, 3 },
                    { 564, new DateTime(2024, 7, 18, 12, 12, 48, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 565, new DateTime(2024, 7, 19, 19, 25, 5, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 566, new DateTime(2024, 7, 20, 2, 38, 22, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 567, new DateTime(2024, 7, 21, 9, 51, 39, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 568, new DateTime(2024, 7, 22, 16, 4, 56, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 569, new DateTime(2024, 7, 23, 23, 17, 13, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 570, new DateTime(2024, 7, 24, 6, 30, 30, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 571, new DateTime(2024, 7, 25, 13, 43, 47, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 572, new DateTime(2024, 7, 26, 20, 56, 4, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 573, new DateTime(2024, 7, 27, 3, 9, 21, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 574, new DateTime(2024, 7, 28, 10, 22, 38, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 575, new DateTime(2024, 7, 29, 17, 35, 55, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 576, new DateTime(2024, 7, 30, 0, 48, 12, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 577, new DateTime(2024, 7, 31, 7, 1, 29, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 578, new DateTime(2024, 8, 1, 14, 14, 46, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 579, new DateTime(2024, 8, 2, 21, 27, 3, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 580, new DateTime(2024, 8, 3, 4, 40, 20, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 581, new DateTime(2024, 8, 4, 11, 53, 37, 0, DateTimeKind.Unspecified), 22, 3 },
                    { 582, new DateTime(2024, 8, 5, 18, 6, 54, 0, DateTimeKind.Unspecified), 23, 1 },
                    { 583, new DateTime(2024, 8, 6, 1, 19, 11, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 584, new DateTime(2024, 8, 7, 8, 32, 28, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 585, new DateTime(2024, 8, 8, 15, 45, 45, 0, DateTimeKind.Unspecified), 26, 1 },
                    { 586, new DateTime(2024, 8, 9, 22, 58, 2, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 587, new DateTime(2024, 8, 10, 5, 11, 19, 0, DateTimeKind.Unspecified), 28, 3 },
                    { 588, new DateTime(2024, 8, 11, 12, 24, 36, 0, DateTimeKind.Unspecified), 29, 1 },
                    { 589, new DateTime(2024, 8, 12, 19, 37, 53, 0, DateTimeKind.Unspecified), 30, 2 },
                    { 590, new DateTime(2024, 8, 13, 2, 50, 10, 0, DateTimeKind.Unspecified), 31, 3 },
                    { 591, new DateTime(2024, 8, 14, 9, 3, 27, 0, DateTimeKind.Unspecified), 32, 1 },
                    { 592, new DateTime(2024, 8, 15, 16, 16, 44, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 593, new DateTime(2024, 8, 16, 23, 29, 1, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 594, new DateTime(2024, 8, 17, 6, 42, 18, 0, DateTimeKind.Unspecified), 35, 1 },
                    { 595, new DateTime(2024, 8, 18, 13, 55, 35, 0, DateTimeKind.Unspecified), 36, 2 },
                    { 596, new DateTime(2024, 8, 19, 20, 8, 52, 0, DateTimeKind.Unspecified), 37, 3 },
                    { 597, new DateTime(2024, 8, 20, 3, 21, 9, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 598, new DateTime(2024, 8, 21, 10, 34, 26, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 599, new DateTime(2024, 8, 22, 17, 47, 43, 0, DateTimeKind.Unspecified), 40, 3 },
                    { 600, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 601, new DateTime(2024, 8, 24, 7, 13, 17, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 602, new DateTime(2024, 8, 25, 14, 26, 34, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 603, new DateTime(2024, 8, 26, 21, 39, 51, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 604, new DateTime(2024, 8, 27, 4, 52, 8, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 605, new DateTime(2024, 8, 28, 11, 5, 25, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 606, new DateTime(2024, 8, 29, 18, 18, 42, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 607, new DateTime(2024, 8, 30, 1, 31, 59, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 608, new DateTime(2024, 8, 31, 8, 44, 16, 0, DateTimeKind.Unspecified), 49, 3 },
                    { 609, new DateTime(2024, 9, 1, 15, 57, 33, 0, DateTimeKind.Unspecified), 50, 1 },
                    { 610, new DateTime(2024, 9, 2, 22, 10, 50, 0, DateTimeKind.Unspecified), 51, 2 },
                    { 611, new DateTime(2024, 9, 3, 5, 23, 7, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 612, new DateTime(2024, 9, 4, 12, 36, 24, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 613, new DateTime(2024, 9, 5, 19, 49, 41, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 614, new DateTime(2024, 9, 6, 2, 2, 58, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 615, new DateTime(2024, 9, 7, 9, 15, 15, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 616, new DateTime(2024, 9, 8, 16, 28, 32, 0, DateTimeKind.Unspecified), 10, 2 },
                    { 617, new DateTime(2024, 9, 9, 23, 41, 49, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 618, new DateTime(2024, 9, 10, 6, 54, 6, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 619, new DateTime(2024, 9, 11, 13, 7, 23, 0, DateTimeKind.Unspecified), 13, 2 },
                    { 620, new DateTime(2024, 9, 12, 20, 20, 40, 0, DateTimeKind.Unspecified), 14, 3 },
                    { 621, new DateTime(2024, 9, 13, 3, 33, 57, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 622, new DateTime(2024, 9, 14, 10, 46, 14, 0, DateTimeKind.Unspecified), 16, 2 },
                    { 623, new DateTime(2024, 9, 15, 17, 59, 31, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 624, new DateTime(2024, 9, 16, 0, 12, 48, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 625, new DateTime(2024, 9, 17, 7, 25, 5, 0, DateTimeKind.Unspecified), 19, 2 },
                    { 626, new DateTime(2024, 9, 18, 14, 38, 22, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 627, new DateTime(2024, 9, 19, 21, 51, 39, 0, DateTimeKind.Unspecified), 21, 1 },
                    { 628, new DateTime(2024, 9, 20, 4, 4, 56, 0, DateTimeKind.Unspecified), 22, 2 },
                    { 629, new DateTime(2024, 9, 21, 11, 17, 13, 0, DateTimeKind.Unspecified), 23, 3 },
                    { 630, new DateTime(2024, 9, 22, 18, 30, 30, 0, DateTimeKind.Unspecified), 24, 1 },
                    { 631, new DateTime(2024, 9, 23, 1, 43, 47, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 632, new DateTime(2024, 9, 24, 8, 56, 4, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 633, new DateTime(2024, 9, 25, 15, 9, 21, 0, DateTimeKind.Unspecified), 27, 1 },
                    { 634, new DateTime(2024, 9, 26, 22, 22, 38, 0, DateTimeKind.Unspecified), 28, 2 },
                    { 635, new DateTime(2024, 9, 27, 5, 35, 55, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 636, new DateTime(2024, 9, 28, 12, 48, 12, 0, DateTimeKind.Unspecified), 30, 1 },
                    { 637, new DateTime(2024, 9, 29, 19, 1, 29, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 638, new DateTime(2024, 9, 30, 2, 14, 46, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 639, new DateTime(2024, 10, 1, 9, 27, 3, 0, DateTimeKind.Unspecified), 33, 1 },
                    { 640, new DateTime(2024, 10, 2, 16, 40, 20, 0, DateTimeKind.Unspecified), 34, 2 },
                    { 641, new DateTime(2024, 10, 3, 23, 53, 37, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 642, new DateTime(2024, 10, 4, 6, 6, 54, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 643, new DateTime(2024, 10, 5, 13, 19, 11, 0, DateTimeKind.Unspecified), 37, 2 },
                    { 644, new DateTime(2024, 10, 6, 20, 32, 28, 0, DateTimeKind.Unspecified), 38, 3 },
                    { 645, new DateTime(2024, 10, 7, 3, 45, 45, 0, DateTimeKind.Unspecified), 39, 1 },
                    { 646, new DateTime(2024, 10, 8, 10, 58, 2, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 647, new DateTime(2024, 10, 9, 17, 11, 19, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 648, new DateTime(2024, 10, 10, 0, 24, 36, 0, DateTimeKind.Unspecified), 42, 1 },
                    { 649, new DateTime(2024, 10, 11, 7, 37, 53, 0, DateTimeKind.Unspecified), 43, 2 },
                    { 650, new DateTime(2024, 10, 12, 14, 50, 10, 0, DateTimeKind.Unspecified), 44, 3 },
                    { 651, new DateTime(2024, 10, 13, 21, 3, 27, 0, DateTimeKind.Unspecified), 45, 1 },
                    { 652, new DateTime(2024, 10, 14, 4, 16, 44, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 653, new DateTime(2024, 10, 15, 11, 29, 1, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 654, new DateTime(2024, 10, 16, 18, 42, 18, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 655, new DateTime(2024, 10, 17, 1, 55, 35, 0, DateTimeKind.Unspecified), 49, 2 },
                    { 656, new DateTime(2024, 10, 18, 8, 8, 52, 0, DateTimeKind.Unspecified), 50, 3 },
                    { 657, new DateTime(2024, 10, 19, 15, 21, 9, 0, DateTimeKind.Unspecified), 51, 1 },
                    { 658, new DateTime(2024, 10, 20, 22, 34, 26, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 659, new DateTime(2024, 10, 21, 5, 47, 43, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 660, new DateTime(2024, 10, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 661, new DateTime(2024, 10, 23, 19, 13, 17, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 662, new DateTime(2024, 10, 24, 2, 26, 34, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 663, new DateTime(2024, 10, 25, 9, 39, 51, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 664, new DateTime(2024, 10, 26, 16, 52, 8, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 665, new DateTime(2024, 10, 27, 23, 5, 25, 0, DateTimeKind.Unspecified), 12, 3 },
                    { 666, new DateTime(2024, 10, 28, 6, 18, 42, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 667, new DateTime(2024, 10, 29, 13, 31, 59, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 668, new DateTime(2024, 10, 30, 20, 44, 16, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 669, new DateTime(2024, 10, 31, 3, 57, 33, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 670, new DateTime(2024, 11, 1, 10, 10, 50, 0, DateTimeKind.Unspecified), 17, 2 },
                    { 671, new DateTime(2024, 11, 2, 17, 23, 7, 0, DateTimeKind.Unspecified), 18, 3 },
                    { 672, new DateTime(2024, 11, 3, 0, 36, 24, 0, DateTimeKind.Unspecified), 19, 1 },
                    { 673, new DateTime(2024, 11, 4, 7, 49, 41, 0, DateTimeKind.Unspecified), 20, 2 },
                    { 674, new DateTime(2024, 11, 5, 14, 2, 58, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 675, new DateTime(2024, 11, 6, 21, 15, 15, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 676, new DateTime(2024, 11, 7, 4, 28, 32, 0, DateTimeKind.Unspecified), 23, 2 },
                    { 677, new DateTime(2024, 11, 8, 11, 41, 49, 0, DateTimeKind.Unspecified), 24, 3 },
                    { 678, new DateTime(2024, 11, 9, 18, 54, 6, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 679, new DateTime(2024, 11, 10, 1, 7, 23, 0, DateTimeKind.Unspecified), 26, 2 },
                    { 680, new DateTime(2024, 11, 11, 8, 20, 40, 0, DateTimeKind.Unspecified), 27, 3 },
                    { 681, new DateTime(2024, 11, 12, 15, 33, 57, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 682, new DateTime(2024, 11, 13, 22, 46, 14, 0, DateTimeKind.Unspecified), 29, 2 },
                    { 683, new DateTime(2024, 11, 14, 5, 59, 31, 0, DateTimeKind.Unspecified), 30, 3 },
                    { 684, new DateTime(2024, 11, 15, 12, 12, 48, 0, DateTimeKind.Unspecified), 31, 1 },
                    { 685, new DateTime(2024, 11, 16, 19, 25, 5, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 686, new DateTime(2024, 11, 17, 2, 38, 22, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 687, new DateTime(2024, 11, 18, 9, 51, 39, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 688, new DateTime(2024, 11, 19, 16, 4, 56, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 689, new DateTime(2024, 11, 20, 23, 17, 13, 0, DateTimeKind.Unspecified), 36, 3 },
                    { 690, new DateTime(2024, 11, 21, 6, 30, 30, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 691, new DateTime(2024, 11, 22, 13, 43, 47, 0, DateTimeKind.Unspecified), 38, 2 },
                    { 692, new DateTime(2024, 11, 23, 20, 56, 4, 0, DateTimeKind.Unspecified), 39, 3 },
                    { 693, new DateTime(2024, 11, 24, 3, 9, 21, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 694, new DateTime(2024, 11, 25, 10, 22, 38, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 695, new DateTime(2024, 11, 26, 17, 35, 55, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 696, new DateTime(2024, 11, 27, 0, 48, 12, 0, DateTimeKind.Unspecified), 43, 1 },
                    { 697, new DateTime(2024, 11, 28, 7, 1, 29, 0, DateTimeKind.Unspecified), 44, 2 },
                    { 698, new DateTime(2024, 11, 29, 14, 14, 46, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 699, new DateTime(2024, 11, 30, 21, 27, 3, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 700, new DateTime(2024, 12, 1, 4, 40, 20, 0, DateTimeKind.Unspecified), 47, 2 },
                    { 701, new DateTime(2024, 12, 2, 11, 53, 37, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 702, new DateTime(2024, 12, 3, 18, 6, 54, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 703, new DateTime(2024, 12, 4, 1, 19, 11, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 704, new DateTime(2024, 12, 5, 8, 32, 28, 0, DateTimeKind.Unspecified), 51, 3 },
                    { 705, new DateTime(2024, 12, 6, 15, 45, 45, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 706, new DateTime(2024, 12, 7, 22, 58, 2, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 707, new DateTime(2024, 12, 8, 5, 11, 19, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 708, new DateTime(2024, 12, 9, 12, 24, 36, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 709, new DateTime(2024, 12, 10, 19, 37, 53, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 710, new DateTime(2024, 12, 11, 2, 50, 10, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 711, new DateTime(2024, 12, 12, 9, 3, 27, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 712, new DateTime(2024, 12, 13, 16, 16, 44, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 713, new DateTime(2024, 12, 14, 23, 29, 1, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 714, new DateTime(2024, 12, 15, 6, 42, 18, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 715, new DateTime(2024, 12, 16, 13, 55, 35, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 716, new DateTime(2024, 12, 17, 20, 8, 52, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 717, new DateTime(2024, 12, 18, 3, 21, 9, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 718, new DateTime(2024, 12, 19, 10, 34, 26, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 719, new DateTime(2024, 12, 20, 17, 47, 43, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 720, new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 721, new DateTime(2024, 12, 22, 7, 13, 17, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 722, new DateTime(2024, 12, 23, 14, 26, 34, 0, DateTimeKind.Unspecified), 22, 3 },
                    { 723, new DateTime(2024, 12, 24, 21, 39, 51, 0, DateTimeKind.Unspecified), 23, 1 },
                    { 724, new DateTime(2024, 12, 25, 4, 52, 8, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 725, new DateTime(2024, 12, 26, 11, 5, 25, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 726, new DateTime(2024, 12, 27, 18, 18, 42, 0, DateTimeKind.Unspecified), 26, 1 },
                    { 727, new DateTime(2024, 12, 28, 1, 31, 59, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 728, new DateTime(2024, 12, 29, 8, 44, 16, 0, DateTimeKind.Unspecified), 28, 3 },
                    { 729, new DateTime(2024, 12, 30, 15, 57, 33, 0, DateTimeKind.Unspecified), 29, 1 },
                    { 730, new DateTime(2024, 1, 1, 22, 10, 50, 0, DateTimeKind.Unspecified), 30, 2 },
                    { 731, new DateTime(2024, 1, 2, 5, 23, 7, 0, DateTimeKind.Unspecified), 31, 3 },
                    { 732, new DateTime(2024, 1, 3, 12, 36, 24, 0, DateTimeKind.Unspecified), 32, 1 },
                    { 733, new DateTime(2024, 1, 4, 19, 49, 41, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 734, new DateTime(2024, 1, 5, 2, 2, 58, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 735, new DateTime(2024, 1, 6, 9, 15, 15, 0, DateTimeKind.Unspecified), 35, 1 },
                    { 736, new DateTime(2024, 1, 7, 16, 28, 32, 0, DateTimeKind.Unspecified), 36, 2 },
                    { 737, new DateTime(2024, 1, 8, 23, 41, 49, 0, DateTimeKind.Unspecified), 37, 3 },
                    { 738, new DateTime(2024, 1, 9, 6, 54, 6, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 739, new DateTime(2024, 1, 10, 13, 7, 23, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 740, new DateTime(2024, 1, 11, 20, 20, 40, 0, DateTimeKind.Unspecified), 40, 3 },
                    { 741, new DateTime(2024, 1, 12, 3, 33, 57, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 742, new DateTime(2024, 1, 13, 10, 46, 14, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 743, new DateTime(2024, 1, 14, 17, 59, 31, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 744, new DateTime(2024, 1, 15, 0, 12, 48, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 745, new DateTime(2024, 1, 16, 7, 25, 5, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 746, new DateTime(2024, 1, 17, 14, 38, 22, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 747, new DateTime(2024, 1, 18, 21, 51, 39, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 748, new DateTime(2024, 1, 19, 4, 4, 56, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 749, new DateTime(2024, 1, 20, 11, 17, 13, 0, DateTimeKind.Unspecified), 49, 3 },
                    { 750, new DateTime(2024, 1, 21, 18, 30, 30, 0, DateTimeKind.Unspecified), 50, 1 },
                    { 751, new DateTime(2024, 1, 22, 1, 43, 47, 0, DateTimeKind.Unspecified), 51, 2 },
                    { 752, new DateTime(2024, 1, 23, 8, 56, 4, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 753, new DateTime(2024, 1, 24, 15, 9, 21, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 754, new DateTime(2024, 1, 25, 22, 22, 38, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 755, new DateTime(2024, 1, 26, 5, 35, 55, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 756, new DateTime(2024, 1, 27, 12, 48, 12, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 757, new DateTime(2024, 1, 28, 19, 1, 29, 0, DateTimeKind.Unspecified), 10, 2 },
                    { 758, new DateTime(2024, 1, 29, 2, 14, 46, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 759, new DateTime(2024, 1, 30, 9, 27, 3, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 760, new DateTime(2024, 1, 31, 16, 40, 20, 0, DateTimeKind.Unspecified), 13, 2 },
                    { 761, new DateTime(2024, 2, 1, 23, 53, 37, 0, DateTimeKind.Unspecified), 14, 3 },
                    { 762, new DateTime(2024, 2, 2, 6, 6, 54, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 763, new DateTime(2024, 2, 3, 13, 19, 11, 0, DateTimeKind.Unspecified), 16, 2 },
                    { 764, new DateTime(2024, 2, 4, 20, 32, 28, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 765, new DateTime(2024, 2, 5, 3, 45, 45, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 766, new DateTime(2024, 2, 6, 10, 58, 2, 0, DateTimeKind.Unspecified), 19, 2 },
                    { 767, new DateTime(2024, 2, 7, 17, 11, 19, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 768, new DateTime(2024, 2, 8, 0, 24, 36, 0, DateTimeKind.Unspecified), 21, 1 },
                    { 769, new DateTime(2024, 2, 9, 7, 37, 53, 0, DateTimeKind.Unspecified), 22, 2 },
                    { 770, new DateTime(2024, 2, 10, 14, 50, 10, 0, DateTimeKind.Unspecified), 23, 3 },
                    { 771, new DateTime(2024, 2, 11, 21, 3, 27, 0, DateTimeKind.Unspecified), 24, 1 },
                    { 772, new DateTime(2024, 2, 12, 4, 16, 44, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 773, new DateTime(2024, 2, 13, 11, 29, 1, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 774, new DateTime(2024, 2, 14, 18, 42, 18, 0, DateTimeKind.Unspecified), 27, 1 },
                    { 775, new DateTime(2024, 2, 15, 1, 55, 35, 0, DateTimeKind.Unspecified), 28, 2 },
                    { 776, new DateTime(2024, 2, 16, 8, 8, 52, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 777, new DateTime(2024, 2, 17, 15, 21, 9, 0, DateTimeKind.Unspecified), 30, 1 },
                    { 778, new DateTime(2024, 2, 18, 22, 34, 26, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 779, new DateTime(2024, 2, 19, 5, 47, 43, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 780, new DateTime(2024, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 33, 1 },
                    { 781, new DateTime(2024, 2, 21, 19, 13, 17, 0, DateTimeKind.Unspecified), 34, 2 },
                    { 782, new DateTime(2024, 2, 22, 2, 26, 34, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 783, new DateTime(2024, 2, 23, 9, 39, 51, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 784, new DateTime(2024, 2, 24, 16, 52, 8, 0, DateTimeKind.Unspecified), 37, 2 },
                    { 785, new DateTime(2024, 2, 25, 23, 5, 25, 0, DateTimeKind.Unspecified), 38, 3 },
                    { 786, new DateTime(2024, 2, 26, 6, 18, 42, 0, DateTimeKind.Unspecified), 39, 1 },
                    { 787, new DateTime(2024, 2, 27, 13, 31, 59, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 788, new DateTime(2024, 2, 28, 20, 44, 16, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 789, new DateTime(2024, 2, 29, 3, 57, 33, 0, DateTimeKind.Unspecified), 42, 1 },
                    { 790, new DateTime(2024, 3, 1, 10, 10, 50, 0, DateTimeKind.Unspecified), 43, 2 },
                    { 791, new DateTime(2024, 3, 2, 17, 23, 7, 0, DateTimeKind.Unspecified), 44, 3 },
                    { 792, new DateTime(2024, 3, 3, 0, 36, 24, 0, DateTimeKind.Unspecified), 45, 1 },
                    { 793, new DateTime(2024, 3, 4, 7, 49, 41, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 794, new DateTime(2024, 3, 5, 14, 2, 58, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 795, new DateTime(2024, 3, 6, 21, 15, 15, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 796, new DateTime(2024, 3, 7, 4, 28, 32, 0, DateTimeKind.Unspecified), 49, 2 },
                    { 797, new DateTime(2024, 3, 8, 11, 41, 49, 0, DateTimeKind.Unspecified), 50, 3 },
                    { 798, new DateTime(2024, 3, 9, 18, 54, 6, 0, DateTimeKind.Unspecified), 51, 1 },
                    { 799, new DateTime(2024, 3, 10, 1, 7, 23, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 800, new DateTime(2024, 3, 11, 8, 20, 40, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 801, new DateTime(2024, 3, 12, 15, 33, 57, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 802, new DateTime(2024, 3, 13, 22, 46, 14, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 803, new DateTime(2024, 3, 14, 5, 59, 31, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 804, new DateTime(2024, 3, 15, 12, 12, 48, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 805, new DateTime(2024, 3, 16, 19, 25, 5, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 806, new DateTime(2024, 3, 17, 2, 38, 22, 0, DateTimeKind.Unspecified), 12, 3 },
                    { 807, new DateTime(2024, 3, 18, 9, 51, 39, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 808, new DateTime(2024, 3, 19, 16, 4, 56, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 809, new DateTime(2024, 3, 20, 23, 17, 13, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 810, new DateTime(2024, 3, 21, 6, 30, 30, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 811, new DateTime(2024, 3, 22, 13, 43, 47, 0, DateTimeKind.Unspecified), 17, 2 },
                    { 812, new DateTime(2024, 3, 23, 20, 56, 4, 0, DateTimeKind.Unspecified), 18, 3 },
                    { 813, new DateTime(2024, 3, 24, 3, 9, 21, 0, DateTimeKind.Unspecified), 19, 1 },
                    { 814, new DateTime(2024, 3, 25, 10, 22, 38, 0, DateTimeKind.Unspecified), 20, 2 },
                    { 815, new DateTime(2024, 3, 26, 17, 35, 55, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 816, new DateTime(2024, 3, 27, 0, 48, 12, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 817, new DateTime(2024, 3, 28, 7, 1, 29, 0, DateTimeKind.Unspecified), 23, 2 },
                    { 818, new DateTime(2024, 3, 29, 14, 14, 46, 0, DateTimeKind.Unspecified), 24, 3 },
                    { 819, new DateTime(2024, 3, 30, 21, 27, 3, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 820, new DateTime(2024, 3, 31, 4, 40, 20, 0, DateTimeKind.Unspecified), 26, 2 },
                    { 821, new DateTime(2024, 4, 1, 11, 53, 37, 0, DateTimeKind.Unspecified), 27, 3 },
                    { 822, new DateTime(2024, 4, 2, 18, 6, 54, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 823, new DateTime(2024, 4, 3, 1, 19, 11, 0, DateTimeKind.Unspecified), 29, 2 },
                    { 824, new DateTime(2024, 4, 4, 8, 32, 28, 0, DateTimeKind.Unspecified), 30, 3 },
                    { 825, new DateTime(2024, 4, 5, 15, 45, 45, 0, DateTimeKind.Unspecified), 31, 1 },
                    { 826, new DateTime(2024, 4, 6, 22, 58, 2, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 827, new DateTime(2024, 4, 7, 5, 11, 19, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 828, new DateTime(2024, 4, 8, 12, 24, 36, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 829, new DateTime(2024, 4, 9, 19, 37, 53, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 830, new DateTime(2024, 4, 10, 2, 50, 10, 0, DateTimeKind.Unspecified), 36, 3 },
                    { 831, new DateTime(2024, 4, 11, 9, 3, 27, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 832, new DateTime(2024, 4, 12, 16, 16, 44, 0, DateTimeKind.Unspecified), 38, 2 },
                    { 833, new DateTime(2024, 4, 13, 23, 29, 1, 0, DateTimeKind.Unspecified), 39, 3 },
                    { 834, new DateTime(2024, 4, 14, 6, 42, 18, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 835, new DateTime(2024, 4, 15, 13, 55, 35, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 836, new DateTime(2024, 4, 16, 20, 8, 52, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 837, new DateTime(2024, 4, 17, 3, 21, 9, 0, DateTimeKind.Unspecified), 43, 1 },
                    { 838, new DateTime(2024, 4, 18, 10, 34, 26, 0, DateTimeKind.Unspecified), 44, 2 },
                    { 839, new DateTime(2024, 4, 19, 17, 47, 43, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 840, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 841, new DateTime(2024, 4, 21, 7, 13, 17, 0, DateTimeKind.Unspecified), 47, 2 },
                    { 842, new DateTime(2024, 4, 22, 14, 26, 34, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 843, new DateTime(2024, 4, 23, 21, 39, 51, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 844, new DateTime(2024, 4, 24, 4, 52, 8, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 845, new DateTime(2024, 4, 25, 11, 5, 25, 0, DateTimeKind.Unspecified), 51, 3 },
                    { 846, new DateTime(2024, 4, 26, 18, 18, 42, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 847, new DateTime(2024, 4, 27, 1, 31, 59, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 848, new DateTime(2024, 4, 28, 8, 44, 16, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 849, new DateTime(2024, 4, 29, 15, 57, 33, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 850, new DateTime(2024, 4, 30, 22, 10, 50, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 851, new DateTime(2024, 5, 1, 5, 23, 7, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 852, new DateTime(2024, 5, 2, 12, 36, 24, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 853, new DateTime(2024, 5, 3, 19, 49, 41, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 854, new DateTime(2024, 5, 4, 2, 2, 58, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 855, new DateTime(2024, 5, 5, 9, 15, 15, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 856, new DateTime(2024, 5, 6, 16, 28, 32, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 857, new DateTime(2024, 5, 7, 23, 41, 49, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 858, new DateTime(2024, 5, 8, 6, 54, 6, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 859, new DateTime(2024, 5, 9, 13, 7, 23, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 860, new DateTime(2024, 5, 10, 20, 20, 40, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 861, new DateTime(2024, 5, 11, 3, 33, 57, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 862, new DateTime(2024, 5, 12, 10, 46, 14, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 863, new DateTime(2024, 5, 13, 17, 59, 31, 0, DateTimeKind.Unspecified), 22, 3 },
                    { 864, new DateTime(2024, 5, 14, 0, 12, 48, 0, DateTimeKind.Unspecified), 23, 1 },
                    { 865, new DateTime(2024, 5, 15, 7, 25, 5, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 866, new DateTime(2024, 5, 16, 14, 38, 22, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 867, new DateTime(2024, 5, 17, 21, 51, 39, 0, DateTimeKind.Unspecified), 26, 1 },
                    { 868, new DateTime(2024, 5, 18, 4, 4, 56, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 869, new DateTime(2024, 5, 19, 11, 17, 13, 0, DateTimeKind.Unspecified), 28, 3 },
                    { 870, new DateTime(2024, 5, 20, 18, 30, 30, 0, DateTimeKind.Unspecified), 29, 1 },
                    { 871, new DateTime(2024, 5, 21, 1, 43, 47, 0, DateTimeKind.Unspecified), 30, 2 },
                    { 872, new DateTime(2024, 5, 22, 8, 56, 4, 0, DateTimeKind.Unspecified), 31, 3 },
                    { 873, new DateTime(2024, 5, 23, 15, 9, 21, 0, DateTimeKind.Unspecified), 32, 1 },
                    { 874, new DateTime(2024, 5, 24, 22, 22, 38, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 875, new DateTime(2024, 5, 25, 5, 35, 55, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 876, new DateTime(2024, 5, 26, 12, 48, 12, 0, DateTimeKind.Unspecified), 35, 1 },
                    { 877, new DateTime(2024, 5, 27, 19, 1, 29, 0, DateTimeKind.Unspecified), 36, 2 },
                    { 878, new DateTime(2024, 5, 28, 2, 14, 46, 0, DateTimeKind.Unspecified), 37, 3 },
                    { 879, new DateTime(2024, 5, 29, 9, 27, 3, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 880, new DateTime(2024, 5, 30, 16, 40, 20, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 881, new DateTime(2024, 5, 31, 23, 53, 37, 0, DateTimeKind.Unspecified), 40, 3 },
                    { 882, new DateTime(2024, 6, 1, 6, 6, 54, 0, DateTimeKind.Unspecified), 41, 1 },
                    { 883, new DateTime(2024, 6, 2, 13, 19, 11, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 884, new DateTime(2024, 6, 3, 20, 32, 28, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 885, new DateTime(2024, 6, 4, 3, 45, 45, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 886, new DateTime(2024, 6, 5, 10, 58, 2, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 887, new DateTime(2024, 6, 6, 17, 11, 19, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 888, new DateTime(2024, 6, 7, 0, 24, 36, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 889, new DateTime(2024, 6, 8, 7, 37, 53, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 890, new DateTime(2024, 6, 9, 14, 50, 10, 0, DateTimeKind.Unspecified), 49, 3 },
                    { 891, new DateTime(2024, 6, 10, 21, 3, 27, 0, DateTimeKind.Unspecified), 50, 1 },
                    { 892, new DateTime(2024, 6, 11, 4, 16, 44, 0, DateTimeKind.Unspecified), 51, 2 },
                    { 893, new DateTime(2024, 6, 12, 11, 29, 1, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 894, new DateTime(2024, 6, 13, 18, 42, 18, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 895, new DateTime(2024, 6, 14, 1, 55, 35, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 896, new DateTime(2024, 6, 15, 8, 8, 52, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 897, new DateTime(2024, 6, 16, 15, 21, 9, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 898, new DateTime(2024, 6, 17, 22, 34, 26, 0, DateTimeKind.Unspecified), 10, 2 },
                    { 899, new DateTime(2024, 6, 18, 5, 47, 43, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 900, new DateTime(2024, 6, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 901, new DateTime(2024, 6, 20, 19, 13, 17, 0, DateTimeKind.Unspecified), 13, 2 },
                    { 902, new DateTime(2024, 6, 21, 2, 26, 34, 0, DateTimeKind.Unspecified), 14, 3 },
                    { 903, new DateTime(2024, 6, 22, 9, 39, 51, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 904, new DateTime(2024, 6, 23, 16, 52, 8, 0, DateTimeKind.Unspecified), 16, 2 },
                    { 905, new DateTime(2024, 6, 24, 23, 5, 25, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 906, new DateTime(2024, 6, 25, 6, 18, 42, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 907, new DateTime(2024, 6, 26, 13, 31, 59, 0, DateTimeKind.Unspecified), 19, 2 },
                    { 908, new DateTime(2024, 6, 27, 20, 44, 16, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 909, new DateTime(2024, 6, 28, 3, 57, 33, 0, DateTimeKind.Unspecified), 21, 1 },
                    { 910, new DateTime(2024, 6, 29, 10, 10, 50, 0, DateTimeKind.Unspecified), 22, 2 },
                    { 911, new DateTime(2024, 6, 30, 17, 23, 7, 0, DateTimeKind.Unspecified), 23, 3 },
                    { 912, new DateTime(2024, 7, 1, 0, 36, 24, 0, DateTimeKind.Unspecified), 24, 1 },
                    { 913, new DateTime(2024, 7, 2, 7, 49, 41, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 914, new DateTime(2024, 7, 3, 14, 2, 58, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 915, new DateTime(2024, 7, 4, 21, 15, 15, 0, DateTimeKind.Unspecified), 27, 1 },
                    { 916, new DateTime(2024, 7, 5, 4, 28, 32, 0, DateTimeKind.Unspecified), 28, 2 },
                    { 917, new DateTime(2024, 7, 6, 11, 41, 49, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 918, new DateTime(2024, 7, 7, 18, 54, 6, 0, DateTimeKind.Unspecified), 30, 1 },
                    { 919, new DateTime(2024, 7, 8, 1, 7, 23, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 920, new DateTime(2024, 7, 9, 8, 20, 40, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 921, new DateTime(2024, 7, 10, 15, 33, 57, 0, DateTimeKind.Unspecified), 33, 1 },
                    { 922, new DateTime(2024, 7, 11, 22, 46, 14, 0, DateTimeKind.Unspecified), 34, 2 },
                    { 923, new DateTime(2024, 7, 12, 5, 59, 31, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 924, new DateTime(2024, 7, 13, 12, 12, 48, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 925, new DateTime(2024, 7, 14, 19, 25, 5, 0, DateTimeKind.Unspecified), 37, 2 },
                    { 926, new DateTime(2024, 7, 15, 2, 38, 22, 0, DateTimeKind.Unspecified), 38, 3 },
                    { 927, new DateTime(2024, 7, 16, 9, 51, 39, 0, DateTimeKind.Unspecified), 39, 1 },
                    { 928, new DateTime(2024, 7, 17, 16, 4, 56, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 929, new DateTime(2024, 7, 18, 23, 17, 13, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 930, new DateTime(2024, 7, 19, 6, 30, 30, 0, DateTimeKind.Unspecified), 42, 1 },
                    { 931, new DateTime(2024, 7, 20, 13, 43, 47, 0, DateTimeKind.Unspecified), 43, 2 },
                    { 932, new DateTime(2024, 7, 21, 20, 56, 4, 0, DateTimeKind.Unspecified), 44, 3 },
                    { 933, new DateTime(2024, 7, 22, 3, 9, 21, 0, DateTimeKind.Unspecified), 45, 1 },
                    { 934, new DateTime(2024, 7, 23, 10, 22, 38, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 935, new DateTime(2024, 7, 24, 17, 35, 55, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 936, new DateTime(2024, 7, 25, 0, 48, 12, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 937, new DateTime(2024, 7, 26, 7, 1, 29, 0, DateTimeKind.Unspecified), 49, 2 },
                    { 938, new DateTime(2024, 7, 27, 14, 14, 46, 0, DateTimeKind.Unspecified), 50, 3 },
                    { 939, new DateTime(2024, 7, 28, 21, 27, 3, 0, DateTimeKind.Unspecified), 51, 1 },
                    { 940, new DateTime(2024, 7, 29, 4, 40, 20, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 941, new DateTime(2024, 7, 30, 11, 53, 37, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 942, new DateTime(2024, 7, 31, 18, 6, 54, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 943, new DateTime(2024, 8, 1, 1, 19, 11, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 944, new DateTime(2024, 8, 2, 8, 32, 28, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 945, new DateTime(2024, 8, 3, 15, 45, 45, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 946, new DateTime(2024, 8, 4, 22, 58, 2, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 947, new DateTime(2024, 8, 5, 5, 11, 19, 0, DateTimeKind.Unspecified), 12, 3 },
                    { 948, new DateTime(2024, 8, 6, 12, 24, 36, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 949, new DateTime(2024, 8, 7, 19, 37, 53, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 950, new DateTime(2024, 8, 8, 2, 50, 10, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 951, new DateTime(2024, 8, 9, 9, 3, 27, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 952, new DateTime(2024, 8, 10, 16, 16, 44, 0, DateTimeKind.Unspecified), 17, 2 },
                    { 953, new DateTime(2024, 8, 11, 23, 29, 1, 0, DateTimeKind.Unspecified), 18, 3 },
                    { 954, new DateTime(2024, 8, 12, 6, 42, 18, 0, DateTimeKind.Unspecified), 19, 1 },
                    { 955, new DateTime(2024, 8, 13, 13, 55, 35, 0, DateTimeKind.Unspecified), 20, 2 },
                    { 956, new DateTime(2024, 8, 14, 20, 8, 52, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 957, new DateTime(2024, 8, 15, 3, 21, 9, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 958, new DateTime(2024, 8, 16, 10, 34, 26, 0, DateTimeKind.Unspecified), 23, 2 },
                    { 959, new DateTime(2024, 8, 17, 17, 47, 43, 0, DateTimeKind.Unspecified), 24, 3 },
                    { 960, new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 961, new DateTime(2024, 8, 19, 7, 13, 17, 0, DateTimeKind.Unspecified), 26, 2 },
                    { 962, new DateTime(2024, 8, 20, 14, 26, 34, 0, DateTimeKind.Unspecified), 27, 3 },
                    { 963, new DateTime(2024, 8, 21, 21, 39, 51, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 964, new DateTime(2024, 8, 22, 4, 52, 8, 0, DateTimeKind.Unspecified), 29, 2 },
                    { 965, new DateTime(2024, 8, 23, 11, 5, 25, 0, DateTimeKind.Unspecified), 30, 3 },
                    { 966, new DateTime(2024, 8, 24, 18, 18, 42, 0, DateTimeKind.Unspecified), 31, 1 },
                    { 967, new DateTime(2024, 8, 25, 1, 31, 59, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 968, new DateTime(2024, 8, 26, 8, 44, 16, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 969, new DateTime(2024, 8, 27, 15, 57, 33, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 970, new DateTime(2024, 8, 28, 22, 10, 50, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 971, new DateTime(2024, 8, 29, 5, 23, 7, 0, DateTimeKind.Unspecified), 36, 3 },
                    { 972, new DateTime(2024, 8, 30, 12, 36, 24, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 973, new DateTime(2024, 8, 31, 19, 49, 41, 0, DateTimeKind.Unspecified), 38, 2 },
                    { 974, new DateTime(2024, 9, 1, 2, 2, 58, 0, DateTimeKind.Unspecified), 39, 3 },
                    { 975, new DateTime(2024, 9, 2, 9, 15, 15, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 976, new DateTime(2024, 9, 3, 16, 28, 32, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 977, new DateTime(2024, 9, 4, 23, 41, 49, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 978, new DateTime(2024, 9, 5, 6, 54, 6, 0, DateTimeKind.Unspecified), 43, 1 },
                    { 979, new DateTime(2024, 9, 6, 13, 7, 23, 0, DateTimeKind.Unspecified), 44, 2 },
                    { 980, new DateTime(2024, 9, 7, 20, 20, 40, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 981, new DateTime(2024, 9, 8, 3, 33, 57, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 982, new DateTime(2024, 9, 9, 10, 46, 14, 0, DateTimeKind.Unspecified), 47, 2 },
                    { 983, new DateTime(2024, 9, 10, 17, 59, 31, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 984, new DateTime(2024, 9, 11, 0, 12, 48, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 985, new DateTime(2024, 9, 12, 7, 25, 5, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 986, new DateTime(2024, 9, 13, 14, 38, 22, 0, DateTimeKind.Unspecified), 51, 3 },
                    { 987, new DateTime(2024, 9, 14, 21, 51, 39, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 988, new DateTime(2024, 9, 15, 4, 4, 56, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 989, new DateTime(2024, 9, 16, 11, 17, 13, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 990, new DateTime(2024, 9, 17, 18, 30, 30, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 991, new DateTime(2024, 9, 18, 1, 43, 47, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 992, new DateTime(2024, 9, 19, 8, 56, 4, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 993, new DateTime(2024, 9, 20, 15, 9, 21, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 994, new DateTime(2024, 9, 21, 22, 22, 38, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 995, new DateTime(2024, 9, 22, 5, 35, 55, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 996, new DateTime(2024, 9, 23, 12, 48, 12, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 997, new DateTime(2024, 9, 24, 19, 1, 29, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 998, new DateTime(2024, 9, 25, 2, 14, 46, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 999, new DateTime(2024, 9, 26, 9, 27, 3, 0, DateTimeKind.Unspecified), 17, 1 },
                    { 1000, new DateTime(2024, 9, 27, 16, 40, 20, 0, DateTimeKind.Unspecified), 18, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "YogaClassAttendanceRecords",
                keyColumn: "Id",
                keyValue: 1000);
        }
    }
}
