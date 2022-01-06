using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ProductWeb.Models;
using ProductWeb.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProductWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ApplewebContext apple = new ApplewebContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }

        public IActionResult Calculation()
        {
            int num1 = Math.Abs(Convert.ToInt32(HttpContext.Request.Form["txt1"].ToString()));
            int num2 = Math.Abs(Convert.ToInt32(HttpContext.Request.Form["txt2"].ToString()));
            int num3 = Math.Abs(Convert.ToInt32(HttpContext.Request.Form["txt3"].ToString()));
            int num4 = Math.Abs(Convert.ToInt32(HttpContext.Request.Form["txt4"].ToString()));
            int amount = num1 + num2 + num3 + num4;
            int totalPrice = (num1 * 27900) + (num2 * 36900) + (num3 * 13400) + (num4 * 75900);

            ViewBag.Num1 = num1.ToString();
            ViewBag.Num2 = num2.ToString();
            ViewBag.Num3 = num3.ToString();
            ViewBag.Num4 = num4.ToString();
            ViewBag.Amount = amount.ToString();
            ViewBag.CalculationResult = totalPrice.ToString();
            return View("Confrim");
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult signin(newuser abc)
        {
            if (ModelState.IsValid)
            {
                return View("Success", abc);
            }
            return View(abc);
        }

        public IActionResult Confrim()
        {
            return View();
        }

        public IActionResult Listitem()
        {
            var ps = from p in apple.AppleProduct select p;
            return View(ps);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
