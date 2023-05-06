using Jewelry_shop.Data.Interfaces;
using Jewelry_shop.Data.Models;
using Jewelry_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Jewelry_shop.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAllUsers _allUsers;

        public AccountController(IAllUsers allUsers)
        {
            _allUsers = allUsers;
        }

        // Register 
        [HttpGet]
        public ActionResult Register() => View();


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _allUsers.getLoginUser(model.Login);
                if (user == null)
                {
                    user = _allUsers.createUser(new User { Login = model.Login, Password = model.Password, Role = 0 });

                    if (user != null)
                    {
                        var result = _allUsers.Authenticate(user);
                        var principal = new ClaimsPrincipal(result);
                        var authPropetries = new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7)
                        };

                        await HttpContext.SignInAsync(principal, authPropetries);

                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Користувач з таким логіном вже існує");
                }
            }
            return View(model);
        }


        // Login
        [HttpGet]
        public ActionResult Login() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _allUsers.getLoginPasswordUser(model.Login, model.Password);
                if (user != null)
                {
                    var result = _allUsers.Authenticate(user);
                    var principal = new ClaimsPrincipal(result);
                    var authPropetries = new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7)
                    };
                    await HttpContext.SignInAsync(principal, authPropetries);

                    return RedirectToAction("Index", "Home");
                }
                else {
                    ModelState.AddModelError("", "Такого користувача не існує");
                }
            }
            return View(model);
        }

        [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("List", "JewelryItems");
        }

    }
}
