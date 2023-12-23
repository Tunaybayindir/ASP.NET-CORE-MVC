using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
        
        public IActionResult Index1()
            {
                string message = $"Hello World. {DateTime.Now.ToString()}";
                return View("Index1",message);
            }
        
        public ViewResult Index3()
            {
                var names = new String[]
                {
                    "Ahmet",
                    "Mehmet",
                    "Ali"
                };
                return View("index3",names);
            }   

        //index350 yukarıdaki urlnin ismi /employee/index350
        //view içindeki yazanda employee dosyasının içindeki cshtml olan dosyalar ekranda gösterir
        public IActionResult Index2()
        {
            return Content("emplyoe");
        }

    }
}