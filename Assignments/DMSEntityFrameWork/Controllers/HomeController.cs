using System.Diagnostics;
using DMSEntityFrameWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMSEntityFrameWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult CreateDoctor(string Name,string Qualification,string Specialisation)
        {
            TempData["Name"] = Name;
            TempData["Qualification"] = Qualification;
            TempData["Specialisation"] = Specialisation;
;
            return RedirectToAction("Create", "Doctors");
        }

        public IActionResult ShowDoctors()
        {
            return RedirectToAction("Index", "Doctors");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
