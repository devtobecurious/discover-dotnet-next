using ConnectWithEfCore.Models;
using ConnectWithEfCore.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConnectWithEfCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DefaultDbContext context;

        public HomeController(ILogger<HomeController> logger, DefaultDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var list = this.context.Wizards.ToList();

            return View(list);
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