using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;



namespace Project.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly UserManager<IdentityUser> userMan;
        private readonly SignInManager<IdentityUser> signIn;

        public UserRegistrationController(UserManager<IdentityUser> userMan, SignInManager<IdentityUser> signIn)
        {
            this.userMan = userMan;
            this.signIn = signIn;
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
           await signIn.SignOutAsync();
            return RedirectToAction("index", "home");

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
        public async Task<IActionResult> Create(UserRegClass userReg)
        {
          if(ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = userReg.UserName };
                var x = await userMan.CreateAsync(user, userReg.Password);

                if(x.Succeeded)
                {
                    await signIn.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                foreach(var error in x.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(userReg);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
       
        public async Task<IActionResult> Login(LoginViewClass log)
        {
            if (ModelState.IsValid)
            {

                var x = await signIn.PasswordSignInAsync(log.UserName, log.Password, false, false);

                if (x.Succeeded)
                {
               
                    return RedirectToAction("index", "home");
                }
             
                
                    ModelState.AddModelError(string.Empty, "Log in failed");
                
            }
            return View(log);
        }
       





        }

}
