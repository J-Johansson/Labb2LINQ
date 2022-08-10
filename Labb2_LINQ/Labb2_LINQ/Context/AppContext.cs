using Labb2_LINQ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2_LINQ.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<SchoolClassCourse> SchoolClassCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-35CC471\SQLEXPRESS;Initial Catalog=SchoolAppLINQ;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
              .HasData(new Course
              {
                  CourseId = 1,
                  CourseName = "Programming"
              });
            modelBuilder.Entity<Course>()
                .HasData(new Course
                {
                    CourseId = 2,
                    CourseName = "Math"
                });
            modelBuilder.Entity<Course>()
                .HasData(new Course
                {
                    CourseId = 3,
                    CourseName = "Swedish"
                });
            modelBuilder.Entity<Course>()
                .HasData(new Course
                {
                    CourseId = 4,
                    CourseName = "History"
                });


            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 1,
                    StudentName = "Jenny Lundin",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1
                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 2,
                    StudentName = "Jonathan Johansson",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1
                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 3,
                    StudentName = "Lisa Häggström",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1
                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 4,
                    StudentName = "Bob Johansson",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1
                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 5,
                    StudentName = "Daniel Svedberg",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1
                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 6,
                    StudentName = "Hugo Svensson",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1
                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 7,
                    StudentName = "Anton Nordin",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1
                });
            modelBuilder.Entity<SchoolClass>()
                .HasData(new SchoolClass
                {
                    SchoolClassId = 1,
                    SchoolClassName = "9A"
                });
            modelBuilder.Entity<SchoolClass>()
                .HasData(new SchoolClass
                {
                    SchoolClassId = 2,
                    SchoolClassName = "8A"
                });
            modelBuilder.Entity<Teacher>()
                .HasData(new Teacher
                {
                    TeacherId = 1,
                    TeacherName = "Reidar Nilsen",
                    fkCourseId = 1
                });
            modelBuilder.Entity<Teacher>()
                .HasData(new Teacher
                {
                    TeacherId = 2,
                    TeacherName = "Anas Alhussain",
                    fkCourseId = 2
                });
            modelBuilder.Entity<SchoolClassCourse>()
                 .HasData(new SchoolClassCourse
                 {
                     SchoolClassCourseId = 1,
                     fkSchoolClassId = 1,
                     fkCourseId = 1

                 });
            modelBuilder.Entity<SchoolClassCourse>()
                 .HasData(new SchoolClassCourse
                 {
                     SchoolClassCourseId = 2,
                     fkSchoolClassId = 2,
                     fkCourseId = 2

                 });
        }
    }
}
