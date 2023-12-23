using Departmanlar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Departmanlar.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context contexts)
        {
            _context = contexts;
        }

        public IActionResult Index()
        {
            var degerler = _context.personels.ToList();
            return View(degerler);
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
