using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPProj.Models;
using FirstASPProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPProj.Controllers
{
/*
 area
action
controller
handler
page
keywords that cannot be used in route*/

    [Route("Teacher/{action=index}")]
    public class StudentController : Controller
    {
        private readonly IStudentServices _services;
        public StudentController(IStudentServices service)
        {
            _services = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _services.GetAllStudent();
            return View(model);
        }

        //[HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
