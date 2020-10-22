using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodegymBALInterface;
using CodegymDomain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodegymApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet("/gets")]
        public IEnumerable<CourseView> GetCourses()
        {
            var courses = courseService.Gets();
            return courses;
        }
    }
}
