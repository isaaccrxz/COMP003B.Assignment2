using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult AboutMe() 
        {
            return View();
        }

        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
