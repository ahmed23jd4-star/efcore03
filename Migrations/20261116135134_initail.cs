using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore03.Migrations
{
    /// <inheritdoc />
    public partial class initail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categery",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    describe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categery", x => x.id);
                    table.ForeignKey(
                        name: "FK_categery_categery_parentid",
                        column: x => x.parentid,
                        principalTable: "categery",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "instercors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datejoining = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instercors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stuents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datebrith = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stuents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    describe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    flag = table.Column<bool>(type: "bit", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    instrucrorid = table.Column<int>(type: "int", nullable: true),
                    catagoryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.id);
                    table.ForeignKey(
                        name: "FK_courses_categery_catagoryid",
                        column: x => x.catagoryid,
                        principalTable: "categery",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_courses_instercors_instrucrorid",
                        column: x => x.instrucrorid,
                        principalTable: "instercors",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "enrolment",
                columns: table => new
                {
                    studentid = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false),
                    statuesstudent = table.Column<int>(type: "int", nullable: false),
                    Finalgrade = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    joindate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enrolment", x => new { x.studentid, x.courseid });
                    table.ForeignKey(
                        name: "FK_enrolment_courses_courseid",
                        column: x => x.courseid,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_enrolment_stuents_studentid",
                        column: x => x.studentid,
                        principalTable: "stuents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categery_parentid",
                table: "categery",
                column: "parentid");

            migrationBuilder.CreateIndex(
                name: "IX_courses_catagoryid",
                table: "courses",
                column: "catagoryid");

            migrationBuilder.CreateIndex(
                name: "IX_courses_instrucrorid",
                table: "courses",
                column: "instrucrorid");

            migrationBuilder.CreateIndex(
                name: "IX_enrolment_courseid",
                table: "enrolment",
                column: "courseid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enrolment");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "stuents");

            migrationBuilder.DropTable(
                name: "categery");

            migrationBuilder.DropTable(
                name: "instercors");
        }
    }
}
