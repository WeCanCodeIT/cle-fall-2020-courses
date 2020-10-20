using cle_fall_2020_courses.Controllers;
using cle_fall_2020_courses.Models;
using cle_fall_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace cle_fall_2020_courses.Tests
{
    public class CourseControllerTests
    {
        CourseController sut;
        IRepository<Course> courseRepo;

        public CourseControllerTests()
        {
            courseRepo = Substitute.For<IRepository<Course>>();
            sut = new CourseController(courseRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            // Act
            var result = sut.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_Courses_To_View()
        {
            // Arrange
            var expectedCourses = new List<Course>();
            courseRepo.GetAll().Returns(expectedCourses);

            var result = sut.Index();

            Assert.IsType<List<Course>>(result.Model);
        }

        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            var expectedCourses = new List<Course>();
            courseRepo.GetAll().Returns(expectedCourses);

            var result = sut.Index();

            Assert.Equal(expectedCourses, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = sut.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            var expectedCourse = new Course();
            courseRepo.GetById(1).Returns(expectedCourse);

            var result = sut.Details(1);

            Assert.Equal(expectedCourse, result.Model);
        }

    }
}
