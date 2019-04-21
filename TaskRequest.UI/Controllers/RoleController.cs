using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskRequest.Application.Roles.Queries.GetAllRoles;
using TaskRequest.Persistence.Domains;

namespace TaskRequest.UI.Controllers
{
    public class RoleController : BaseController
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public RoleController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var result = await Mediator.Send(new GetAllRolesQuery());
            return View(result);
        }
    }
}