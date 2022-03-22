using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {

        private Context newContext { get; set; }

        public HomeController(Context temp)
        {
            newContext = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Group gr)
        {
            newContext.Add(gr);
            newContext.SaveChanges();

            return View("Index");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(TimeSlot ts)
        {
            newContext.Add(ts);
            newContext.SaveChanges();
            return View("Form");
        }

        [HttpGet]
        public IActionResult Appointments()
        {
            var appt = newContext.Groups
                .Include(x => x.TimeSlot)
                .ToList();
            //ViewBag.times = newContext.Times.ToList();

            return View(appt);
        }

    }
}
