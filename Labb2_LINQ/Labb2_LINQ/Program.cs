using System;
using Labb2_LINQ.Models;
using System.Collections.Generic;
using System.Linq;
using Labb2_LINQ.Context;

namespace Labb2_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using ApplicationContext context = new ApplicationContext();


            Console.WriteLine("Select (1-5)");
            Console.WriteLine("1 = Get all teachers that teaches Programming 1.");
            Console.WriteLine("2 = Get all students and their teachers name.");
            Console.WriteLine("3 = Get all students that studies Programming 1 and their names and teacher");
            Console.WriteLine("4 = Edit a course to a different one.");
            Console.WriteLine("5 = Update a students teacher in a course to a different teacher");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("All teachers teaching Programming 1");
                    Console.WriteLine("*****************************************");

                    var queryProgramming = (from c in context.Teachers
                                        from p in context.Courses
                                        where p.CourseName == "Programming" && c.fkCourseId == 1
                                        select new { TeacherName = c.TeacherName, CourseName = p.CourseName }).ToList();
                    foreach (var item in queryProgramming)
                    {
                        Console.WriteLine("Teacher: " + item.TeacherName + " Course: " + item.CourseName);
                    }
                    Console.ReadKey();
                    
                    break;
                    

                case 2:
                    Console.WriteLine("Get all students and their teachers name.");
                    Console.WriteLine("*****************************************");


                    var queryStudentTeacher = (from c in context.Students
                                               from p in context.Teachers
                                               select new { StudentName = c.StudentName, TeacherName = p.TeacherName }).Distinct().ToList();
                    foreach (var item in queryStudentTeacher)
                    {
                        Console.WriteLine("Student: " + item.StudentName + " - Teacher: " + item.TeacherName);
                    }

                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Get all students that studies Programming 1 and their names and teacher");
                    Console.WriteLine("*****************************************");

                    var queryProgrammingStudent = (from u in context.Courses
                                              from p in context.Teachers
                                              from y in context.Students
                                              where p.fkCourseId == 1 && u.CourseName == "Programming"
                                              select new { StudentName = y.StudentName, TeacherName = p.TeacherName }).ToList();
                    foreach (var item in queryProgrammingStudent)
                    {
                        Console.WriteLine("Student: " + item.StudentName + " - Teacher: " + item.TeacherName);
                    }

                    Console.ReadKey();

                    break;

                case 4:
                    Console.WriteLine("Edit a course to a different one.");
                    Console.WriteLine("*****************************************");

                    var queryChangeCourse = (from c in context.Courses
                                       where c.CourseName == "History"
                                       select new { CourseName = "Tech" });
                    context.SaveChanges();

                    foreach (var item in queryChangeCourse)
                    {
                        Console.WriteLine("CourseName: " + item.CourseName);
                    }

                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Update a students teacher in a course to a different teacher");
                    Console.WriteLine("*****************************************");

                    var queryTeacherChange = (from c in context.Courses
                                              from p in context.Teachers
                                              from y in context.Students
                                              where c.CourseName == "Programming" && p.TeacherName == "Reidar" && p.TeacherId == 1 && y.StudentId == 1
                                              select new { CourseName = c.CourseName, TeacherName = "Anas", TeacherId = 2, StudentId = y.StudentId });
                    context.SaveChanges();
                    foreach (var item in queryTeacherChange)
                    {
                        Console.WriteLine("CourseName: " + item.CourseName + " Teacher: " + item.TeacherName);
                    }

                    Console.ReadKey();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
