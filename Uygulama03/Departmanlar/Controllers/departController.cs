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
            var degerler = _context.departmanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            _context.Add(d);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartSil(int id)
        {
            var dep = _context.departmanlars.Find(id);
            _context.departmanlars.Remove(dep);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartGetir(int id)
        {
            var dep = _context.departmanlars.Find(id);
            return View("DepartGetir", dep);
        }
        public IActionResult DepartmanGuncelle(departmanlar d)
        {
            var dep = _context.departmanlars.Find(d.ID);
            dep.departmanAd = d.departmanAd;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
