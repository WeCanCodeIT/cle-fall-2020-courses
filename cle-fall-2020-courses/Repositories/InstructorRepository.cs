﻿using cle_fall_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_fall_2020_courses.Repositories
{
    public class InstructorRepository : IRepository<Instructor>
    {
        private UniversityContext db;
        public InstructorRepository(UniversityContext db)
        {
            this.db = db;
        }

        public IEnumerable<Instructor> GetAll()
        {
            return db.Instructors;
        }

        public Instructor GetById(int id)
        {
            return db.Instructors.Single(c => c.Id == id);
        }


    }
}