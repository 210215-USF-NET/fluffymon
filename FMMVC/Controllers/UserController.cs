using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FMModels;
using FMBL;
using FMMVC.Models;

namespace StoreMVC.Controllers
{
    public class UserController : Controller
    {
        private IFluffyBL fluffyBL;
        public UserController(IFluffyBL fluffyBL)
        {
            this.fluffyBL = fluffyBL;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(CreateUserViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.UserName = userVM.UserName;
                //string blOutput = FMBL.CreateUser(user);
                string blOutput = null;
                if (blOutput == null)
                {
                    return RedirectToAction("Login");
                }
                return BadRequest(blOutput);
            }
            return BadRequest("Invalid model state");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(LoginUserViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                //User user = FMBL.GetUserByName(userVM.UserName);
                User user = new User { UserId = 1, UserName = "asdf" };
                if (user == null)
                {
                    return NotFound();
                }
                HttpContext.Session.SetString("UserName", user.UserName);
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return Redirect("/");
            }
            return BadRequest("Invalid model state");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserName");
            HttpContext.Session.Remove("UserId");
            return RedirectToAction("Login");
        }
    }
}