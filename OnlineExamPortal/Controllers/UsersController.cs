using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineExamPortal.Models;
using OnlineExamPortal.Services;

namespace OnlineExamPortal.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {

            return View(await _usersService.GetUsersAsync("SELECT * FROM c"));
        }
        [ActionName("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("Id,FirstName,LastName,Email,Gender,Mobile,Pin,Password,Address,Image,CustomField1,CustomField2,CustomField3")] Users user)
        {
            if (ModelState.IsValid)
            {
                user.Id = Guid.NewGuid().ToString();
                await _usersService.AddUserAsync(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }
        
    }
}