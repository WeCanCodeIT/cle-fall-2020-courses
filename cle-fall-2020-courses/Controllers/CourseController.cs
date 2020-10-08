using cle_fall_2020_courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_fall_2020_courses.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            Course course = new Course(1, "Intro to MVC", "All you need to know about MVC");

            return View(course);
        }
    }
}
