using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Trello.Controllers
{
    public class AuthController : Controller
    {
        public AuthController()
        {

        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            ViewData["Title"] = "Sign Up";

            return View();
        }
    }
}
