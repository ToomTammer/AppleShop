using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductWeb.Models;
using ProductWeb.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProductWeb.Controllers
{
    public class Addpayment : Controller
    {
        PaymentlistContext payment = new PaymentlistContext();
        public IActionResult Record()
        {
            var ps = from p in payment.Pmlist select p;
            return View(ps);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Record(Pmlist products)
        {
            if (ModelState.IsValid)
            {
                payment.Add(products);
                await payment.SaveChangesAsync();
                return RedirectToAction(nameof(Complete));
            }
            return View(products);
        }

        public IActionResult Complete()
        {
           return View();
        }

        public IActionResult Search(string querry)
        {
            if (string.IsNullOrEmpty(querry))
            {
                return View("Record", payment.Pmlist.ToList());
            }
            else
            {
                return View("Record", payment.Pmlist.Where(p => p.CustomerName.Contains(querry)));
            }
        }
    }
}
