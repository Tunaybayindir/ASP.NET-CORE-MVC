using Departmanlar.Migrations;
using Departmanlar.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Departmanlar.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(Admin a)
        {
            var bilgiler = _context.Admins.FirstOrDefault(x => x.Kullanici == a.Kullanici && x.Sifre == a.Sifre);
            if(bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.Kullanici)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal  =new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Personel"); 

            }
            return View();
        }
    }
}
