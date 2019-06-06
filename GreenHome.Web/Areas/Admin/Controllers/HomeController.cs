using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenHome.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GreenHome.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }
    }
}