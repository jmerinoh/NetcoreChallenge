using System;
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
            return Content(
                "{"
                +"\"cou1\": {\"name\": \"Windows 10\",\"desc\":\"W Fundamentals\",\"price\": 299,\"status\": \"available\" }"
                +",\"cou2\": {\"name\": \"Networking\",\"desc\":\"Networking for PRO\",\"price\": 799,\"status\": \"available\" }"
                +"}"
                , "application/json");
        }

    }
}
