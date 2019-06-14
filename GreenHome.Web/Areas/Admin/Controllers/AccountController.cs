using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenHome.Data.Entities;
using GreenHome.Utilities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GreenHome.Web.Areas.Admin.Controllers
{
  
    public class AccountController : BaseController
    {
        private readonly SignInManager<AppUser> _signInManager;
     

        public AccountController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
         
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Admin/Login/Index");
        }
    }
}