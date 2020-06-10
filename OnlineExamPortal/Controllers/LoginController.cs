using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OnlineExamPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineExamPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        private readonly OnlineExamPortalDbContext _context;


        public LoginController(OnlineExamPortalDbContext context)
        {
            _context = context;
        }

        [Route("Get")]
        public string get()
        {
            return "Hello Login Controller";
        }
        [AllowAnonymous]
        [Route("Register")] 
        public async Task<Users> Register(Users user)
        {
            if (user != null)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }

        [AllowAnonymous]
        [Route("Login")]
        public async Task<List<Users>> Login(Users user)
        {
            if (user != null)
            {
                return await _context.Users.Where(u => user.Email == u.Email && user.Password == u.Password).ToListAsync();
            }
            else
            {
                return null;
            }
        }
    }
}