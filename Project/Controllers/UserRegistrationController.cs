using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly ApplicationUserClass auc;
        public UserRegistrationController(ApplicationUserClass ac)
        {
            auc = ac;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserRegClass ur)
        {
            auc.Add(ur);
            auc.SaveChanges();
            ViewBag.message = "The User " + ur.UserName + " is successfully registered";
            return View();
        }
    }
}
