﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private Context newContext { get; set; }

        public HomeController(ILogger<HomeController> logger, Context temp)
        {
            _logger = logger;
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
            return View();
        }

        [HttpGet]
        public IActionResult Appointments ()
        {
            var appt = newContext.Responses.ToList();
            //var time = newContext.times.ToList();

            return View(appt);
        }

    }
}
