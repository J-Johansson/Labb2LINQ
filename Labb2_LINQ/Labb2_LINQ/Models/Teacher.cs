using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb2_LINQ.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }


        [ForeignKey("Courses")]
        public int fkCourseId { get; set; }
        public Course Courses { get; set; }
    }
}
