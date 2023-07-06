using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Routage.Models;

namespace Routage.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index(string message)
		{
			return View(message);
		}

        public IActionResult Yell()
        {
            return View("Index", "HELLO !!");
        }

        public IActionResult Say()
        {
            return View("Index", "Hello.");
        }

        [Route("/Say_Hello", Name = "say")]
		public IActionResult SayHello()
		{
			return Say();
		}

		[Route("/Yell_Hello", Name = "yell")]
		public IActionResult YellHello()
		{
			return Yell();
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