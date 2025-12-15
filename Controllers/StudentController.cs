using CaprarSalajan_AnaCezara_Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaprarSalajan_AnaCezara_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }
    }
}
