using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LINQ_testDB.Migrations
{
    /// <inheritdoc />
    public partial class dataupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1001,
                column: "teacherID",
                value: 102);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1003,
                column: "teacherID",
                value: 103);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1004,
                column: "teacherID",
                value: 104);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1006,
                column: "teacherID",
                value: 102);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1007,
                column: "teacherID",
                value: 103);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1008,
                column: "teacherID",
                value: 104);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1010,
                column: "teacherID",
                value: 102);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1001,
                column: "teacherID",
                value: 101);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1003,
                column: "teacherID",
                value: 101);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1004,
                column: "teacherID",
                value: 101);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1006,
                column: "teacherID",
                value: 101);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1007,
                column: "teacherID",
                value: 101);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1008,
                column: "teacherID",
                value: 101);

            migrationBuilder.UpdateData(
                table: "TeacherStudentSubject",
                keyColumn: "id",
                keyValue: 1010,
                column: "teacherID",
                value: 101);
        }
    }
}
