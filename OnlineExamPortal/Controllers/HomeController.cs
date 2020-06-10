using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineExamPortal.Models;
using OnlineExamPortal.Repository;

namespace OnlineExamPortal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Employees> _context;
        public HomeController(ILogger<HomeController> logger, IRepository<Employees> context)
        {
            _logger = logger;
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_context.GetAll());
        }
        [HttpGet]
        [ActionName("Create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
        public ActionResult Create(Employees employee)
        {
            if (ModelState.IsValid)
            {
                // employee.Id = _context.GetAll().Count() + 1;
                _context.Add(employee);
                return RedirectToAction("Index");

            }
            return View(employee);
        }

        public IActionResult Edit(int id)
        {
            var emp = _context.GetById(id);
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public ActionResult Edit(Employees employee)
        {
            if (ModelState.IsValid)
            {
                // employee.Id = _context.GetAll().Count() + 1;
                _context.Modify(employee);
                return RedirectToAction("Index");

            }
            return View(employee);
        }

        [HttpGet]
        [ActionName("Details")]
        public IActionResult Details(int id)
        {
            return View(_context.GetById(id));
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            _context.DeleteById(id);
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
