using Departmanlar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Departmanlar.Controllers
{
    public class PersonelController : Controller
    {
        private readonly Context _context;
        
        public PersonelController(Context context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            var degerler = _context.Personels.Include(x=>x.Birim).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in _context.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.BirimAd,
                                                 Value = x.BirimID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(Personel d)
        {
            var per = _context.Birims.Where(x=>x.BirimID == d.Birim.BirimID).FirstOrDefault();
            d.Birim = per;
            _context.Personels.Add(d);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
