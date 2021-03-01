using Microsoft.AspNetCore.Mvc;
using SDProject03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace SDProject03.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        //GET:/<Controller>

        [Route("/Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [Route("/Register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");

                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View();
        }






       //[Route ("/")]

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }






        //GET:/<Controller>

        [Route("/account/Login")]

        // [Route("/user/login")]
        [HttpGet]
       // [AllowAnonymous]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }






        [Route("/account/Login")]
        //  [AllowAnonymous]

        [HttpPost]
       public async Task<IActionResult> Login(LoginViewModel loginmodel)
        {
            if (ModelState.IsValid)
            {
               // ApplicationUser signedUser = UserManager.FindByEmail(model.Email);

                // var a = await signInManager.CheckPasswordSignInAsync(loginmodel.Email, loginmodel.Password, loginmodel.RememberMe);
                var result = await signInManager.PasswordSignInAsync(loginmodel.Email, loginmodel.Password, loginmodel.RememberMe,false);
                if (result.Succeeded)
                {
                    //await userManager.AddClaimAsync(user, new Claim("UserRole", "Admin"));
                    return RedirectToAction("index","home");
                }

                else
                ModelState.AddModelError(string.Empty, "Invalid Login Attept");

            }
            else
                ModelState.AddModelError(string.Empty, "Invalid Model");


            return View(loginmodel);
           

        }
    }

}

