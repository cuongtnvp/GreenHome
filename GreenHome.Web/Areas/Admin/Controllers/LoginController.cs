﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenHome.Data.Entities;
using GreenHome.Utilities.Dtos;
using GreenHome.Web.Models.AccountViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GreenHome.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        //private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager
            , ILogger<LoginController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authen(LoginViewModel model)
        {
          
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                  
                    _logger.LogInformation("User logged in.");
                    return new OkObjectResult(new GenericResult(true));
                }
                //if (result.RequiresTwoFactor)
                //{
                //    return RedirectToAction(nameof(LoginWith2fa), new { returnUrl, model.RememberMe });
                //}
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return new OkObjectResult(new GenericResult(false,"Tài khoản đã bị khóa"));
                }
                else
                {
                    //ModelState.AddModelError(string.Empty, "Đăng nhập không đúng.");
                    return new OkObjectResult(new GenericResult(false, "Đăng nhập sai"));
                }
            }

            // If we got this far, something failed, redisplay form
            return new OkObjectResult(new GenericResult(false, model));
        }
    }
}