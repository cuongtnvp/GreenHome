using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GreenHome.Web.Areas.Admin.Controllers
{
  
    public class RelationshipController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}