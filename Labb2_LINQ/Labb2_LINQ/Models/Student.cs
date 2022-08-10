using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb2_LINQ.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }



        [ForeignKey("SchoolClasses")]
        public int fkSchoolClassId { get; set; }
        public int fkStudentTeacherId { get; set; }
        public SchoolClass SchoolClasses { get; set; }


        //    public int ClassId { get; set; }
        //    public Class Class { get; set; }

        //    public virtual ICollection<StudentCourse> CourseStudents { get; set; }
        }
    }
