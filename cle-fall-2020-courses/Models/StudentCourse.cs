﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_fall_2020_courses.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }

        // Navigation properties for many-to-many
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}
