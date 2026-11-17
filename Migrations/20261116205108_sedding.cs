using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace efcore03.Migrations
{
    /// <inheritdoc />
    public partial class sedding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categery",
                columns: new[] { "id", "describe", "name", "parentid" },
                values: new object[,]
                {
                    { 1, null, "Programming", null },
                    { 2, null, "Design", null }
                });

            migrationBuilder.InsertData(
                table: "instercors",
                columns: new[] { "id", "Bio", "datejoining", "fullname" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed Hassan" },
                    { 2, null, new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara Ali" },
                    { 3, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omar Khaled" }
                });

            migrationBuilder.InsertData(
                table: "categery",
                columns: new[] { "id", "describe", "name", "parentid" },
                values: new object[,]
                {
                    { 3, null, "Web Development", 1 },
                    { 4, null, "ASP.NET Core", 2 }
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "id", "catagoryid", "date", "describe", "flag", "instrucrorid", "level", "price", "title" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, 3, 49.99m, "C# Fundamentals" });

            migrationBuilder.InsertData(
                table: "categery",
                columns: new[] { "id", "describe", "name", "parentid" },
                values: new object[] { 5, null, "UI/UX", 3 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "id", "catagoryid", "date", "describe", "flag", "instrucrorid", "level", "price", "title" },
                values: new object[,]
                {
                    { 2, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, 3, 29.99m, "HTML & CSS Basics" },
                    { 3, 4, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, 2, 79.99m, "ASP.NET Core Web API" },
                    { 6, 4, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, 1, 99.99m, "EF Core Deep Dive" }
                });

            migrationBuilder.InsertData(
                table: "categery",
                columns: new[] { "id", "describe", "name", "parentid" },
                values: new object[] { 6, null, "Figma", 5 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "id", "catagoryid", "date", "describe", "flag", "instrucrorid", "level", "price", "title" },
                values: new object[,]
                {
                    { 5, 5, null, null, false, 2, 1, 89.99m, "Advanced UI/UX Patterns" },
                    { 4, 6, null, null, false, 3, 3, 39.99m, "Figma for Beginners" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categery",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categery",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "instercors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "instercors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "instercors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categery",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categery",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categery",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categery",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
