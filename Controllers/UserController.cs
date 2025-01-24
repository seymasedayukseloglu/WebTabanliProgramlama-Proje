using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Florals.Models;
using System.Linq;

namespace Florals.Controllers
{
    public class UserController : Controller
    {
        private readonly myAppContext _context;

        public UserController(myAppContext context)
        {
            _context = context;
        }

        public IActionResult KayitYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KayitYap(KayitModel kayit)
        {
            if (string.IsNullOrEmpty(kayit.Name) || string.IsNullOrEmpty(kayit.Email) || string.IsNullOrEmpty(kayit.Password))
            {
                ViewBag.Error = "You need to fill in all the fields.";
                return View();
            }

            if (_context.Users.Any(u => u.Email == kayit.Email))
            {
                ViewBag.Error = "This email address is already registered.";
                return View();
            }

            var user = new User
            {
                Name = kayit.Name,
                Email = kayit.Email,
                Password = kayit.Password,
                Role = "User" 
            };

            _context.Users.Add(user);
            _context.SaveChanges();


            HttpContext.Session.SetString("Email", user.Email);
            HttpContext.Session.SetString("Name", user.Name);

            return RedirectToAction("Index", "Home");
        }


        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GirisYap(GirisModel giris)
        {

            if (string.IsNullOrEmpty(giris.Email) || string.IsNullOrEmpty(giris.Password))
            {
                ViewBag.Error = "You need to fill in all the fields.";
                return View();
            }


            var user = _context.Users.FirstOrDefault(u => u.Email == giris.Email);

 
            if (user == null || user.Password != giris.Password)
            {
                ViewBag.Error = "Invalid email or password.";
                return View();
            }


            HttpContext.Session.SetString("Email", user.Email);
            HttpContext.Session.SetString("Name", user.Name);


            if (user.Role == "Admin")
            {
                return RedirectToAction("Index", "Admin");
            }

            return RedirectToAction("Index", "Home");
        }


        public IActionResult CikisYap()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("GirisYap", "User"); 
        }
    }
}
