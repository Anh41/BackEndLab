
using Microsoft.AspNetCore.Mvc;
using ServerGame106.Models;

namespace ServerGame106.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lab1Controller : ControllerBase
    {
        public IActionResult Get()
        {
            GameLab1 game106 = new GameLab1
            {
                CourseName = "Back-End Game Programming",
                CourseCode = "GAM106",
                Name = "Nguyen Hoang Ky Anh",
                StudentCode = "PD09911",
                Class = "GA19301",
            };
            int year = 2025;
            string school = "FPT Polytechnic";
            var data = new { game106, year, school };

            return new JsonResult(data);
        }
    }
}
