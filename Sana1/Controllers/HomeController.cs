using Microsoft.AspNetCore.Mvc;
using Sana1.Models;
using System.Diagnostics;

namespace Sana1.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
		public IActionResult Index()
		{
			return View();
		}

		[Route("/Name")]
		public IActionResult Name(string name)
        {
            ViewBag.Name = name;    

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
