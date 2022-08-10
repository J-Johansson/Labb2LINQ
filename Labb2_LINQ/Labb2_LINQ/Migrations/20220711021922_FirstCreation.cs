using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2_LINQ.Migrations
{
    public partial class FirstCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClasses",
                columns: table => new
                {
                    SchoolClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolClassName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClasses", x => x.SchoolClassId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(nullable: true),
                    fkCourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_Courses_fkCourseId",
                        column: x => x.fkCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClassCourses",
                columns: table => new
                {
                    SchoolClassCourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fkCourseId = table.Column<int>(nullable: false),
                    fkSchoolClassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClassCourses", x => x.SchoolClassCourseId);
                    table.ForeignKey(
                        name: "FK_SchoolClassCourses_Courses_fkCourseId",
                        column: x => x.fkCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolClassCourses_SchoolClasses_fkSchoolClassId",
                        column: x => x.fkSchoolClassId,
                        principalTable: "SchoolClasses",
                        principalColumn: "SchoolClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: true),
                    fkSchoolClassId = table.Column<int>(nullable: false),
                    fkStudentTeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_SchoolClasses_fkSchoolClassId",
                        column: x => x.fkSchoolClassId,
                        principalTable: "SchoolClasses",
                        principalColumn: "SchoolClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Programming", 0 },
                    { 2, "Math", 0 },
                    { 3, "Swedish", 0 },
                    { 4, "History", 0 }
                });

            migrationBuilder.InsertData(
                table: "SchoolClasses",
                columns: new[] { "SchoolClassId", "SchoolClassName" },
                values: new object[,]
                {
                    { 1, "9A" },
                    { 2, "8A" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentName", "fkSchoolClassId", "fkStudentTeacherId" },
                values: new object[,]
                {
                    { 1, "Jenny Lundin", 1, 1 },
                    { 2, "Jonathan Johansson", 1, 1 },
                    { 3, "Lisa Häggström", 1, 1 },
                    { 4, "Bob Johansson", 1, 1 },
                    { 5, "Daniel Svedberg", 1, 1 },
                    { 6, "Hugo Svensson", 1, 1 },
                    { 7, "Anton Nordin", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "TeacherName", "fkCourseId" },
                values: new object[,]
                {
                    { 1, "Reidar Nilsen", 1 },
                    { 2, "Anas Alhussain", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClassCourses_fkCourseId",
                table: "SchoolClassCourses",
                column: "fkCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClassCourses_fkSchoolClassId",
                table: "SchoolClassCourses",
                column: "fkSchoolClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_fkSchoolClassId",
                table: "Students",
                column: "fkSchoolClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_fkCourseId",
                table: "Teachers",
                column: "fkCourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolClassCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "SchoolClasses");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
