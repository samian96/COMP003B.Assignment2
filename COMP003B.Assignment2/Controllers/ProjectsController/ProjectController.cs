using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers.ProjectsController
{
    public class ProjectController : Controller
    {
        public IActionResult Current()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Completed()
        {
            return View();
        }

        [HttpGet] 

        public IActionResult Ideas()
        {
            return View();
        }
    }
}
