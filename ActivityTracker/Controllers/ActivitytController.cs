using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using ActivityTracker.Models;

namespace ActivityTracker.Controllers
{
    public class ActivitytController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ActivitytController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var items = _db.Activities.ToList();

            if (items == null)
            {
                return View("Not Found");
            }

            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id, Name, Date")] Activityt activityt)
        {
            if (ModelState.IsValid)
            {
                _db.Add(activityt);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}