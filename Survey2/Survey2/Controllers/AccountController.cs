using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Survey2.Models;

namespace Survey2.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signinManager;

        public AccountController(UserManager<AppUser> _userManager, SignInManager<AppUser> _signinManager)
        {
            userManager = _userManager;
            signinManager = _signinManager;
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByNameAsync(model.Name);

                if (user!=null)
                {
                    await signinManager.SignOutAsync();
                    var result = await signinManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/Admin");
                    }
                }
                ModelState.AddModelError("Name", "Hatalı Kullancı Adı veya Şifre");
            }
            
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signinManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {            
            return View();
        }

        public IActionResult ResetPassword(string token)
        {
            return View();
        }

        public IActionResult SendPasswordResetLink(string username)
        {
            AppUser user = userManager.
                 FindByNameAsync(username).Result;

            if (user == null || !(userManager.IsEmailConfirmedAsync(user).Result))
            {
                ViewBag.Message = "Şifrenizi sıfırlarken bir hata oluştu!";
                return View("Error");
            }

            var token = userManager.
                  GeneratePasswordResetTokenAsync(user).Result;

            var resetLink = Url.Action("ResetPassword", "Account", new { token }, protocol: HttpContext.Request.Scheme);

            // code to email the above link
            // see the earlier article

            ViewBag.Message = "Şifre sıfırlama linki adresinize gönderildi!";
            return View("Login");

        }
    }
}