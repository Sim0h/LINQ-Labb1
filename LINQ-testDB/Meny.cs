using LINQ_testDB.models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_testDB
{
    internal class Meny
    {
        public static void MenyStart()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Välkommen till menyn:");
                Console.WriteLine("1. Alla Mattelärare");
                Console.WriteLine("2. Lärare och Studenter");
                Console.WriteLine("3. Finns Programmering 1");
                Console.WriteLine("4. Byt Programmering 2 till OOP");
                Console.WriteLine("5. Byt Lärare från Anas till Tobias");
                Console.WriteLine("6. Avsluta");

                Console.Write("Välj ett alternativ (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MathTeacher();
                        break;
                    case "2":
                        TeacherAndStudent();
                        break;
                    case "3":
                        isProg1();
                        break;
                    case "4":
                        changeToOOP();
                        break;
                    case "5":
                        ChangeRecord();
                        break;
                    case "6":
                        exit = true;
                        Console.WriteLine("Avslutar...");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen välj ett nummer från 1 till 6.");
                        break;
                }

                Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void TeacherAndStudent()
        {
            using LINQDbContext context = new LINQDbContext();
            var studentsWithTeachers = from tss in context.TeacherStudentSubject
                                       join teacher in context.Teacher on tss.teacherID equals teacher.teacherID
                                       join student in context.Student on tss.studentID equals student.studentID
                                       select new
                                       {
                                           StudentID = student.studentID,
                                           StudentName = student.studentName,
                                           TeacherName = teacher.teacherName
                                       };

            foreach (var student in studentsWithTeachers)
            {
                Console.WriteLine($"Student ID: {student.StudentID}, Student: {student.StudentName}, Lärare: {student.TeacherName}");
            }
        }

        public static void isProg1()
        {
            using LINQDbContext context = new LINQDbContext();
            var prog1Subject = context.Subject.FirstOrDefault(obj => obj.subjectName == "Programmering 1");

            if (prog1Subject != null)
            {
                Console.WriteLine("Programmering 1 finns");
            }
            else
            {
                Console.WriteLine("Programmering 1 finns inte.");
            }
        }

        public static void changeToOOP()
        {
            using LINQDbContext context = new LINQDbContext();
            var changeSubject = context.Subject.FirstOrDefault(sub => sub.subjectName == "Projektledning");

            if (changeSubject != null)
            {
                changeSubject.subjectName = "OOP";
                //context.SaveChanges(); inför redovisning
            }
            Console.WriteLine("Ämnet Projektledning har ändrats till OOP");

            Console.WriteLine("--------------------");
            var subjects = context.Subject.ToList();
            foreach (var subject in subjects)
            {
                Console.WriteLine("ID{0} - Kursnamn = {1}", subject.subjectID, subject.subjectName);
            }

        }

        public static void ChangeRecord()
        {
            using LINQDbContext context = new LINQDbContext();


            var studentsWithTeachers = from tss in context.TeacherStudentSubject
                                       join teacher in context.Teacher on tss.teacherID equals teacher.teacherID
                                       join student in context.Student on tss.studentID equals student.studentID
                                       where teacher.teacherName == "Anas"
                                       select new
                                       {
                                           StudentID = student.studentID,
                                           StudentName = student.studentName,
                                           TeacherName = teacher.teacherName
                                       };

            foreach (var student in studentsWithTeachers)
            {
                Console.WriteLine($"Student ID: {student.StudentID}, Student: {student.StudentName}, Teacher: {student.TeacherName}");
            }

            // har inte Reidar som lärare, så bytt till Tobias istället. 
            Console.WriteLine("Välj vilken Student du vill ändra Lärare på (Student ID).");
            int choice = Convert.ToInt32(Console.ReadLine());

            var selectedStudent = context.TeacherStudentSubject.FirstOrDefault(s => s.studentID == choice);
            if (selectedStudent != null)
            {
                var tobias = context.Teacher.FirstOrDefault(t => t.teacherName == "Tobias");
                if (tobias != null)
                {
                    selectedStudent.teacherID = tobias.teacherID;
                    Console.WriteLine("Studentens lärare är uppdaterad till Tobias.");
                    //context.SaveChanges(); inför redovisning
                }
                else
                {
                    Console.WriteLine("Tobias kan inte hittas.");
                }
            }
            else
            {
                Console.WriteLine("Student ID är ej korret.");
            }

        }

        public static void MathTeacher()
        {
            using LINQDbContext context = new LINQDbContext();
            var mathTeachers = context.TeacherStudentSubject.Where(tss => tss.subjectID == 12)
                .Select(tss => tss.Teacher.teacherName).Distinct().ToList();
            foreach (var tss in mathTeachers)
            {
                Console.WriteLine(tss);
            }
        }

    }

    
}
