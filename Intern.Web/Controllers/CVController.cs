using InternIngressInternal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InternIngressInternal.Intern.Web.Controllers
{
    public class CVController : Controller
    {
        private readonly ILogger<CVController> _logger;

        public CVController(ILogger<CVController> logger)
        {
            _logger = logger;
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