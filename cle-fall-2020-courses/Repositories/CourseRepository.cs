﻿using cle_fall_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_fall_2020_courses.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private UniversityContext db;
        public CourseRepository(UniversityContext db)
        {
            this.db = db;
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses;
        }

        public Course GetById(int id)
        {
            return db.Courses.Single(c => c.Id == id);
        }

    }
}
