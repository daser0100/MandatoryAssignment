using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IT.Models;
using Microsoft.EntityFrameworkCore;

namespace IT.Controllers
{
    public class HomeController : Controller
    {

        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        // GET: About
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "About - 1362";
            ViewData["DisplayedTitle"] = "Kitchen 1362 - About";
            ViewData["Message"] = "";
            return View(await _context.About.ToListAsync());
        }

        public async Task<IActionResult> Gallery()
        {
            ViewData["Title"] = "Gallery - 1362";
            ViewData["DisplayedTitle"] = "Kitchen 1362 - Gallery";
            ViewData["Message"] = "";

            return View(await _context.Gallery.ToListAsync());
        }

        public IActionResult Admin()
        {
            ViewData["Title"] = "Admin - 1362";
            ViewData["DisplayedTitle"] = "Kitchen 1362 - Admin page";
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult News()
        {
            ViewData["Title"] = "News - 1362";
            ViewData["DisplayedTitle"] = "Kitchen 1362 - News";
            ViewData["Message"] = "";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> News([Bind("ID,RoomNumber,FrontName,LastName,DisplayName,EMail,PhoneNumber,AccountNumber,Password")] News news)
        {
            if (ModelState.IsValid)
            {
                _context.Add(news);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Signed));
            }
            return View(news);
        }

        public IActionResult Signed()
        {
            ViewData["Title"] = "Signup - 1362";
            ViewData["DisplayedTitle"] = "Kitchen 1362 - Signup";
            ViewData["Message"] = "You have succesfully signed up :)";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
