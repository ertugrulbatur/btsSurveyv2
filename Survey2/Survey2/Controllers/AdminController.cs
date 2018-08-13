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
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        //private Survey2.Models.ViewModels.SurveyViewModel vm;
        private UserManager<AppUser> userManager;
        private IPasswordValidator<AppUser> passValidator;
        private IPasswordHasher<AppUser> passHasher;

        public AdminController(UserManager<AppUser> _userManager, IPasswordValidator<AppUser> _passValidator, IPasswordHasher<AppUser> _passHasher)
        {
            userManager = _userManager;
            passValidator = _passValidator;
            passHasher = _passHasher;
        }
        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser();
               // user.Id = Guid.NewGuid();
                user.UserName = model.Name;
                //user.PasswordHash = model.Password;
                user.Email = null;

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }



            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string Id) {
            AppUser user = await userManager.FindByIdAsync(Id);

            if(user != null)
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else{
                ModelState.AddModelError("", "User Not Found!");
            }

            return View("Index", userManager.Users);
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(string Id, string Password)
        {
            AppUser user = await userManager.FindByIdAsync(Id);

            if (user != null)
            {
                IdentityResult validPass = null;

                if (!string.IsNullOrEmpty(Password))
                {
                    validPass = await passValidator.ValidateAsync(userManager, user, Password);

                    if (validPass.Succeeded)
                    {
                        user.PasswordHash = passHasher.HashPassword(user, Password);
                    }

                    else
                    {
                        foreach (var item in validPass.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }

                if (validPass.Succeeded)
                {
                    var result = await userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
               
                
            }
            else
            {
                ModelState.AddModelError("", "User Not Found!");
            }            
                return View(user);
            
        }
    }
}