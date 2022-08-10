using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_LINQ.Models
{
    public class SchoolClass
    {
        [Key]
        public int SchoolClassId { get; set; }
        public string SchoolClassName { get; set; }

        public ICollection<SchoolClassCourse> SchoolClassCourses { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
