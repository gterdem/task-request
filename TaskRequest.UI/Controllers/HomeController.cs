using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskRequest.Application.Roles.Commands.CreateRole;
using TaskRequest.Application.Roles.Queries.GetAllRoles;
using TaskRequest.Persistence.Domains;
using TaskRequest.Persistence.IRepository;
using TaskRequest.UI.Models;

namespace TaskRequest.UI.Controllers
{
    public class HomeController : BaseController
    {
        //private readonly IGenericRepository _repository;
        private readonly RoleManager<ApplicationRole> _roleManager;
        public HomeController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            //var result = await Mediator.Send(new GetAllRolesQuery());
            //var list = await _repository.GetAllAsync<ApplicationRole>(t => true);
            //await _roleManager.CreateAsync(new ApplicationRole
            //{
            //    Name = "PatatesRole"
            //});
            //var dojo = result;
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            //CreateRoleCommand cmd = new CreateRoleCommand
            //{
            //    Name = "DomatesRole"
            //};
            //var result = await Mediator.Send(cmd);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
