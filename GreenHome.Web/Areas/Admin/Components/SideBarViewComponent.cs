using GreenHome.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenHome.Web.Extensions;
using System.Security.Claims;
using GreenHome.Application.ViewModels.System;
using GreenHome.Utilities.Constants;

namespace GreenHome.Web.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {
        private IFunctionService _functionService;

        public SideBarViewComponent(IFunctionService functionService)
        {
            _functionService = functionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<FunctionViewModel> functions;
            if (roles.Split(";").Contains(CommonConstants.AdminRole))
            {
                functions = await _functionService.GetAll();
            }
            else
            {
                //TODO: Get by permission
                functions = new List<FunctionViewModel>();
            }
            return View(functions);
        }
    }
}
