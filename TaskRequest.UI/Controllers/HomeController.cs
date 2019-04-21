using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskRequest.Persistence.Domains;
//using TaskRequest.Persistence.Domains;
//using TaskRequest.Persistence.IRepository;
using TaskRequest.UI.Models;

namespace TaskRequest.UI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IGenericRepository _repository;
        //public HomeController(IGenericRepository repository)
        //{
        //    _repository = repository;
        //}
        private readonly RoleManager<ApplicationRole> _roleManager;
        public HomeController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            //var list = _repository.GetAll<ApplicationRole>(t => true);
            //await _roleManager.CreateAsync(new ApplicationRole
            //{
            //    Name = "PatatesRole"
            //});
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
