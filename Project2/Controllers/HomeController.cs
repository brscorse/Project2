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

        // this ain't working idk what to do
        [HttpGet]
        public IActionResult Form(int id)
        {

            ViewBag.time = id;
            //var appt = newContext.Groups.Single(x => x.TimeSlotId == id);
        
            return View(new Group());
        }

        [HttpPost]
        public IActionResult Form(Group group)
        {
            if (ModelState.IsValid)
            {
                newContext.Add(group);
                newContext.SaveChanges();

                return View("Appointments", group);
            }
            else
            {
                return View(group);

            }
        }

        [HttpGet]
        public IActionResult Edit(int groupid, int timeid)
        {
            ViewBag.time = timeid;

            var appt = newContext.Groups.Single(x => x.GroupId == groupid);

            return View("Form", appt);
        }

        [HttpPost]
        public IActionResult Edit(Group group)
        {
            newContext.Update(group);
            newContext.SaveChanges();

            return RedirectToAction("Appointments");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            var sign = newContext.Times
            .Where(x => x.Available == true)
            .OrderBy(x => x.Date)
            .ToList();
            

            return View(sign);
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

            return View(appt);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var appt = newContext.Groups.Single(x => x.GroupId == id);

            return View("DeleteConfirmation", appt);
        }


        [HttpPost]
        public IActionResult Delete(Group group)
        {
            newContext.Groups.Remove(group);
            newContext.SaveChanges();

            return RedirectToAction("Appointments");
        }


    }
}
