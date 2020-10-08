using cle_fall_2020_courses.Controllers;
using cle_fall_2020_courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace cle_fall_2020_courses.Tests
{
    public class CourseControllerTests
    {
        CourseController sut;
        
        public CourseControllerTests()
        {
            sut = new CourseController();
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
        public void Index_Returns_CourseModel_To_View()
        {
            var result = sut.Index();

            Assert.IsType<Course>(result.Model);
        }
    }
}
