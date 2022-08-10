using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb2_LINQ.Models
{
    public class SchoolClassCourse
    {
        [Key]
        public int SchoolClassCourseId { get; set; }

        [ForeignKey("Courses")]
        public int fkCourseId { get; set; }
        public Course Courses { get; set; }

        [ForeignKey("SchoolClasses")]
        public int fkSchoolClassId { get; set; }
        public SchoolClass SchoolClasses { get; set; }
    }
}
