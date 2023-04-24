using Microsoft.AspNetCore.Mvc;
using Penguin.Cms.Template.Models;
using System.Diagnostics;

namespace Penguin.Cms.Template.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}