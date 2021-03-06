﻿using cle_fall_2020_courses.Models;
using cle_fall_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_fall_2020_courses.Controllers
{
    public class CourseController : Controller
    {

        IRepository<Course> courseRepo;

        public CourseController(IRepository<Course> courseRepo)
        {
            this.courseRepo = courseRepo;
        }
        public ViewResult Index()
        {
            var model = courseRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = courseRepo.GetById(id);

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreateByInstructorId(int id)
        {
            ViewBag.InstructorId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            course.LastRevision = DateTime.Now.ToString("MM/dd/yyyy");

            if (ModelState.IsValid)
            {
                courseRepo.Create(course);
                // return RedirectToAction("Index");
                // return RedirectToAction("Details", new { id = course.Id });
                return RedirectToAction("Details", "Instructor", new { id = course.InstructorId });
            }
            return View(course);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Course model = courseRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Course course)
        {
            if (ModelState.IsValid)
            {
                courseRepo.Update(course);
                return RedirectToAction("Details", "Course", new { id = course.Id });
            }
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Course model = courseRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Course course)
        {
            courseRepo.Delete(course);

            return RedirectToAction("Index");

        }

    }
}
