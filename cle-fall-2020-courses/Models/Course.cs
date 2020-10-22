using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cle_fall_2020_courses.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Description { get; set; }
        public string LastRevision { get; set; }

        // Navigation properties to establish one-to-many relationship with Instructor
        [Display(Name = "Instructor")]
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        // Navigation properties to establish many-to-many relationship with Students
        public virtual List<StudentCourse> StudentCourses { get; set; }

        public Course()
        {

        }

        public Course(int id, string name, string description, string lastRevision)
        {
            Id = id;
            Name = name;
            Description = description;
            LastRevision = lastRevision;
        }
    }
}
