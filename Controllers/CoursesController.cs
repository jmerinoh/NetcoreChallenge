using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetcoreChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string valuex = "{";
            // Gets all courses in database
            using (var context = new LibraryContext())
            {
                var courses = context.Course;
                foreach (var course in courses)
                {
                    valuex = valuex + (valuex == "{" ? "" : ",")
                    + "\"cou" + course.course_id + "\":"
                    + "{\"name\":" + " \"" + course.name + "\""
                    + ",\"desc\":" + " \"" + course.desc + "\""
                    + ",\"price\":" + " " + course.price
                    + ",\"status\":" + " \"" + course.status + "\""
                    + "}"
                    ;
                }
            }
            Console.WriteLine(valuex);
            return Content(valuex + "}");
        }

    }
}
