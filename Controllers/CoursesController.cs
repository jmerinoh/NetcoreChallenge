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
            //return new string[] { "course1", "course2" };
            // return Content(
            //     "{"
            //     + "\"cou1\": {\"name\": \"Windows 10\",\"desc\":\"W Fundamentals\",\"price\": 299,\"status\": \"available\" }"
            //     + ",\"cou2\": {\"name\": \"Networking\",\"desc\":\"Networking for PRO\",\"price\": 799,\"status\": \"available\" }"
            //     + "}"
            //     , "application/json");
            string valuex = "{";
            // Gets and prints all courses in database
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
                    // data.AppendLine($"desc: {course.desc}");
                    // data.AppendLine($"status: {course.status}");
                    // valuex = valuex + data.ToString();
                }
            }
            Console.WriteLine(valuex);
            return Content(valuex+"}");
        }

    }
}
