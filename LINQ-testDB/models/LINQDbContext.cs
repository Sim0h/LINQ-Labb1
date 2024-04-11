using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_testDB.models
{
    internal class LINQDbContext : DbContext
    {
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<TeacherStudentSubject> TeacherStudentSubject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = DESKTOP-QCSHMVR;Initial Catalog = DbLINQSchool;Integrated Security=True;TrustServerCertificate=Yes;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(new Subject { subjectID = 10, subjectName = "Avancerad .NET" });
            modelBuilder.Entity<Subject>().HasData(new Subject { subjectID = 11, subjectName = "Projektledning" });
            modelBuilder.Entity<Subject>().HasData(new Subject { subjectID = 12, subjectName = "Matematik" });
            

            modelBuilder.Entity<Class>().HasData(new Class { classID = 1, className = "SUT23" });
            modelBuilder.Entity<Class>().HasData(new Class { classID = 2, className = "ITP23" });


            modelBuilder.Entity<Teacher>().HasData(new Teacher { teacherID = 101, teacherName = "Anas" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { teacherID = 102, teacherName = "Tobias" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { teacherID = 103, teacherName = "Sara" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { teacherID = 104, teacherName = "Sam" });


            modelBuilder.Entity<Student>().HasData(new Student { studentID = 201, studentName = "Erik" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 202, studentName = "Johan" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 203, studentName = "John" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 204, studentName = "Anna" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 205, studentName = "Lisa" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 206, studentName = "Stina" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 207, studentName = "Karin" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 208, studentName = "Patrik" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 209, studentName = "Alice" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 210, studentName = "Simon" });
            modelBuilder.Entity<Student>().HasData(new Student { studentID = 211, studentName = "Noah" });


            modelBuilder.Entity<TeacherStudentSubject>().HasData(
                new TeacherStudentSubject { id = 1000, teacherID = 101, subjectID = 12, studentID = 201 , classID = 2 }, 
                new TeacherStudentSubject { id = 1001, teacherID = 102, subjectID = 12, studentID = 202 , classID = 2 }, 
                new TeacherStudentSubject { id = 1002, teacherID = 101, subjectID = 10, studentID = 203 , classID = 2 },
                new TeacherStudentSubject { id = 1003, teacherID = 103, subjectID = 12, studentID = 204 , classID = 2 },
                new TeacherStudentSubject { id = 1004, teacherID = 104, subjectID = 11, studentID = 205 , classID = 2 },
                new TeacherStudentSubject { id = 1005, teacherID = 101, subjectID = 11, studentID = 206 , classID = 1 },
                new TeacherStudentSubject { id = 1006, teacherID = 102, subjectID = 11, studentID = 207 , classID = 1 },
                new TeacherStudentSubject { id = 1007, teacherID = 103, subjectID = 11, studentID = 208, classID = 1 },
                new TeacherStudentSubject { id = 1008, teacherID = 104, subjectID = 10, studentID = 209 , classID = 1 },
                new TeacherStudentSubject { id = 1009, teacherID = 101, subjectID = 10, studentID = 210, classID = 1 },
                new TeacherStudentSubject { id = 1010, teacherID = 102, subjectID = 10, studentID = 211 , classID = 1 }
                );
        }
    }
}
