using Microsoft.AspNetCore.Mvc;
using Departmanlar.Models;
using System;

namespace Departmanlar.Controllers
{
    public class departController : Controller
    {
        //veri tabanı çekme
        private readonly Context _context;

        public departController(Context context)
        {
            _context = context;
        }
        //bitiş
        public IActionResult Index()
        {
            var degerler = _context.Birims.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(Birim d)
        {
            _context.Add(d);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartSil(int id)
        {
            var dep = _context.Birims.Find(id);
            _context.Birims.Remove(dep);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartGetir(int id)
        {
            var dep = _context.Birims.Find(id);
            return View("DepartGetir", dep);
        }
        public IActionResult DepartmanGuncelle(Birim d)
        {
            var dep = _context.Birims.Find(d.BirimID);
            dep.BirimAd = d.BirimAd;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimDetay(int id)
        {
            var degerler = _context.Personels.Where(x => x.BirimID == id).ToList();
            return View(degerler);
        }
    }
}
