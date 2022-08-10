using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2_LINQ.Migrations
{
    public partial class SecondPush : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SchoolClassCourses",
                columns: new[] { "SchoolClassCourseId", "fkCourseId", "fkSchoolClassId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "SchoolClassCourses",
                columns: new[] { "SchoolClassCourseId", "fkCourseId", "fkSchoolClassId" },
                values: new object[] { 2, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SchoolClassCourses",
                keyColumn: "SchoolClassCourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolClassCourses",
                keyColumn: "SchoolClassCourseId",
                keyValue: 2);
        }
    }
}
