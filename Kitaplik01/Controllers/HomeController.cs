using Kitaplık.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Kitaplık.Models;

namespace Kitaplık.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Kitaplik()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){UrunId=1,UrunAd="insan ne ile yasar",UrunYazar="L.N TOLSTOY"},
                new Kitaplar(){UrunId=2,UrunAd="Fareler ve insanlar",UrunYazar="John Steinbeck"},
                new Kitaplar(){UrunId=3,UrunAd="Savaş Sanatı",UrunYazar="Sun tzi"},
                new Kitaplar(){UrunId=4,UrunAd="Hayvan Ciftligi",UrunYazar="George Orwell"},
                new Kitaplar(){UrunId=5,UrunAd="Turklesmek islamlasmak muassirlasmak",UrunYazar="Ziya Gökalp"},
                new Kitaplar(){UrunId=6,UrunAd="Kumarbaz",UrunYazar="Dostoyevski"}
            };
            return View(ktp);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
