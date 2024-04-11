using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LINQ_testDB.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    classID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    className = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.classID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    studentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.studentID);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    subjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.subjectID);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    teacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.teacherID);
                });

            migrationBuilder.CreateTable(
                name: "TeacherStudentSubject",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacherID = table.Column<int>(type: "int", nullable: false),
                    subjectID = table.Column<int>(type: "int", nullable: false),
                    studentID = table.Column<int>(type: "int", nullable: false),
                    classID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherStudentSubject", x => x.id);
                    table.ForeignKey(
                        name: "FK_TeacherStudentSubject_Class_classID",
                        column: x => x.classID,
                        principalTable: "Class",
                        principalColumn: "classID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherStudentSubject_Student_studentID",
                        column: x => x.studentID,
                        principalTable: "Student",
                        principalColumn: "studentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherStudentSubject_Subject_subjectID",
                        column: x => x.subjectID,
                        principalTable: "Subject",
                        principalColumn: "subjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherStudentSubject_Teacher_teacherID",
                        column: x => x.teacherID,
                        principalTable: "Teacher",
                        principalColumn: "teacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "classID", "className" },
                values: new object[,]
                {
                    { 1, "SUT23" },
                    { 2, "ITP23" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "studentID", "studentName" },
                values: new object[,]
                {
                    { 201, "Erik" },
                    { 202, "Johan" },
                    { 203, "John" },
                    { 204, "Anna" },
                    { 205, "Lisa" },
                    { 206, "Stina" },
                    { 207, "Karin" },
                    { 208, "Patrik" },
                    { 209, "Alice" },
                    { 210, "Simon" },
                    { 211, "Noah" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "subjectID", "subjectName" },
                values: new object[,]
                {
                    { 10, "Avancerad .NET" },
                    { 11, "Projektledning" },
                    { 12, "Matematik" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "teacherID", "teacherName" },
                values: new object[,]
                {
                    { 101, "Anas" },
                    { 102, "Tobias" },
                    { 103, "Sara" },
                    { 104, "Sam" }
                });

            migrationBuilder.InsertData(
                table: "TeacherStudentSubject",
                columns: new[] { "id", "classID", "studentID", "subjectID", "teacherID" },
                values: new object[,]
                {
                    { 1000, 2, 201, 12, 101 },
                    { 1001, 2, 202, 12, 101 },
                    { 1002, 2, 203, 10, 101 },
                    { 1003, 2, 204, 12, 101 },
                    { 1004, 2, 205, 11, 101 },
                    { 1005, 1, 206, 12, 101 },
                    { 1006, 1, 207, 11, 101 },
                    { 1007, 1, 208, 11, 101 },
                    { 1008, 1, 209, 10, 101 },
                    { 1009, 1, 210, 10, 101 },
                    { 1010, 1, 211, 10, 101 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherStudentSubject_classID",
                table: "TeacherStudentSubject",
                column: "classID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherStudentSubject_studentID",
                table: "TeacherStudentSubject",
                column: "studentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherStudentSubject_subjectID",
                table: "TeacherStudentSubject",
                column: "subjectID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherStudentSubject_teacherID",
                table: "TeacherStudentSubject",
                column: "teacherID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherStudentSubject");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
