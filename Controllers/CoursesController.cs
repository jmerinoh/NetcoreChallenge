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
        public IEnumerable<Course> Get()
        {
            // Gets all courses in database
            using (var context = new LibraryContext())
                return context.Course.ToList();
        }

    }
}
