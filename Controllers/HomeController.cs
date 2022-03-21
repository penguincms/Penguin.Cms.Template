using Microsoft.AspNetCore.Mvc;
using Penguin.Cms.Template.Models;
using System.Diagnostics;

namespace Penguin.Cms.Template.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });

        public IActionResult Index() => this.View();

        public IActionResult Privacy() => this.View();
    }
}