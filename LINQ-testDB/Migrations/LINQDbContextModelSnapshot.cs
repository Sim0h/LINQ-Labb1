﻿// <auto-generated />
using LINQ_testDB.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LINQ_testDB.Migrations
{
    [DbContext(typeof(LINQDbContext))]
    partial class LINQDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LINQ_testDB.models.Class", b =>
                {
                    b.Property<int>("classID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("classID"));

                    b.Property<string>("className")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("classID");

                    b.ToTable("Class");

                    b.HasData(
                        new
                        {
                            classID = 1,
                            className = "SUT23"
                        },
                        new
                        {
                            classID = 2,
                            className = "ITP23"
                        });
                });

            modelBuilder.Entity("LINQ_testDB.models.Student", b =>
                {
                    b.Property<int>("studentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentID"));

                    b.Property<string>("studentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("studentID");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            studentID = 201,
                            studentName = "Erik"
                        },
                        new
                        {
                            studentID = 202,
                            studentName = "Johan"
                        },
                        new
                        {
                            studentID = 203,
                            studentName = "John"
                        },
                        new
                        {
                            studentID = 204,
                            studentName = "Anna"
                        },
                        new
                        {
                            studentID = 205,
                            studentName = "Lisa"
                        },
                        new
                        {
                            studentID = 206,
                            studentName = "Stina"
                        },
                        new
                        {
                            studentID = 207,
                            studentName = "Karin"
                        },
                        new
                        {
                            studentID = 208,
                            studentName = "Patrik"
                        },
                        new
                        {
                            studentID = 209,
                            studentName = "Alice"
                        },
                        new
                        {
                            studentID = 210,
                            studentName = "Simon"
                        },
                        new
                        {
                            studentID = 211,
                            studentName = "Noah"
                        });
                });

            modelBuilder.Entity("LINQ_testDB.models.Subject", b =>
                {
                    b.Property<int>("subjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subjectID"));

                    b.Property<string>("subjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("subjectID");

                    b.ToTable("Subject");

                    b.HasData(
                        new
                        {
                            subjectID = 10,
                            subjectName = "Avancerad .NET"
                        },
                        new
                        {
                            subjectID = 11,
                            subjectName = "Projektledning"
                        },
                        new
                        {
                            subjectID = 12,
                            subjectName = "Matematik"
                        });
                });

            modelBuilder.Entity("LINQ_testDB.models.Teacher", b =>
                {
                    b.Property<int>("teacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teacherID"));

                    b.Property<string>("teacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teacherID");

                    b.ToTable("Teacher");

                    b.HasData(
                        new
                        {
                            teacherID = 101,
                            teacherName = "Anas"
                        },
                        new
                        {
                            teacherID = 102,
                            teacherName = "Tobias"
                        },
                        new
                        {
                            teacherID = 103,
                            teacherName = "Sara"
                        },
                        new
                        {
                            teacherID = 104,
                            teacherName = "Sam"
                        });
                });

            modelBuilder.Entity("LINQ_testDB.models.TeacherStudentSubject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("classID")
                        .HasColumnType("int");

                    b.Property<int>("studentID")
                        .HasColumnType("int");

                    b.Property<int>("subjectID")
                        .HasColumnType("int");

                    b.Property<int>("teacherID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("classID");

                    b.HasIndex("studentID");

                    b.HasIndex("subjectID");

                    b.HasIndex("teacherID");

                    b.ToTable("TeacherStudentSubject");

                    b.HasData(
                        new
                        {
                            id = 1000,
                            classID = 2,
                            studentID = 201,
                            subjectID = 12,
                            teacherID = 101
                        },
                        new
                        {
                            id = 1001,
                            classID = 2,
                            studentID = 202,
                            subjectID = 12,
                            teacherID = 102
                        },
                        new
                        {
                            id = 1002,
                            classID = 2,
                            studentID = 203,
                            subjectID = 10,
                            teacherID = 101
                        },
                        new
                        {
                            id = 1003,
                            classID = 2,
                            studentID = 204,
                            subjectID = 12,
                            teacherID = 103
                        },
                        new
                        {
                            id = 1004,
                            classID = 2,
                            studentID = 205,
                            subjectID = 11,
                            teacherID = 104
                        },
                        new
                        {
                            id = 1005,
                            classID = 1,
                            studentID = 206,
                            subjectID = 12,
                            teacherID = 101
                        },
                        new
                        {
                            id = 1006,
                            classID = 1,
                            studentID = 207,
                            subjectID = 11,
                            teacherID = 102
                        },
                        new
                        {
                            id = 1007,
                            classID = 1,
                            studentID = 208,
                            subjectID = 11,
                            teacherID = 103
                        },
                        new
                        {
                            id = 1008,
                            classID = 1,
                            studentID = 209,
                            subjectID = 10,
                            teacherID = 104
                        },
                        new
                        {
                            id = 1009,
                            classID = 1,
                            studentID = 210,
                            subjectID = 10,
                            teacherID = 101
                        },
                        new
                        {
                            id = 1010,
                            classID = 1,
                            studentID = 211,
                            subjectID = 10,
                            teacherID = 102
                        });
                });

            modelBuilder.Entity("LINQ_testDB.models.TeacherStudentSubject", b =>
                {
                    b.HasOne("LINQ_testDB.models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("classID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LINQ_testDB.models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("studentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LINQ_testDB.models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("subjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LINQ_testDB.models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("teacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
