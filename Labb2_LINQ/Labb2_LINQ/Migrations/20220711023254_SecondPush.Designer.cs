﻿// <auto-generated />
using Labb2_LINQ.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb2_LINQ.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220711023254_SecondPush")]
    partial class SecondPush
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb2_LINQ.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Programming",
                            TeacherId = 0
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Math",
                            TeacherId = 0
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "Swedish",
                            TeacherId = 0
                        },
                        new
                        {
                            CourseId = 4,
                            CourseName = "History",
                            TeacherId = 0
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.SchoolClass", b =>
                {
                    b.Property<int>("SchoolClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SchoolClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolClassId");

                    b.ToTable("SchoolClasses");

                    b.HasData(
                        new
                        {
                            SchoolClassId = 1,
                            SchoolClassName = "9A"
                        },
                        new
                        {
                            SchoolClassId = 2,
                            SchoolClassName = "8A"
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.SchoolClassCourse", b =>
                {
                    b.Property<int>("SchoolClassCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("fkCourseId")
                        .HasColumnType("int");

                    b.Property<int>("fkSchoolClassId")
                        .HasColumnType("int");

                    b.HasKey("SchoolClassCourseId");

                    b.HasIndex("fkCourseId");

                    b.HasIndex("fkSchoolClassId");

                    b.ToTable("SchoolClassCourses");

                    b.HasData(
                        new
                        {
                            SchoolClassCourseId = 1,
                            fkCourseId = 1,
                            fkSchoolClassId = 1
                        },
                        new
                        {
                            SchoolClassCourseId = 2,
                            fkCourseId = 2,
                            fkSchoolClassId = 2
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fkSchoolClassId")
                        .HasColumnType("int");

                    b.Property<int>("fkStudentTeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("fkSchoolClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            StudentName = "Jenny Lundin",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            StudentName = "Jonathan Johansson",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            StudentName = "Lisa Häggström",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 4,
                            StudentName = "Bob Johansson",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 5,
                            StudentName = "Daniel Svedberg",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 6,
                            StudentName = "Hugo Svensson",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            StudentName = "Anton Nordin",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fkCourseId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("fkCourseId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            TeacherName = "Reidar Nilsen",
                            fkCourseId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            TeacherName = "Anas Alhussain",
                            fkCourseId = 2
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.SchoolClassCourse", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Course", "Courses")
                        .WithMany("SchoolClassCourses")
                        .HasForeignKey("fkCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2_LINQ.Models.SchoolClass", "SchoolClasses")
                        .WithMany("SchoolClassCourses")
                        .HasForeignKey("fkSchoolClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Student", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.SchoolClass", "SchoolClasses")
                        .WithMany("Students")
                        .HasForeignKey("fkSchoolClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Teacher", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Course", "Courses")
                        .WithMany("Teachers")
                        .HasForeignKey("fkCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
