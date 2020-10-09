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

    /*[Route("Teacher/{action=index}")]*/
    public class StudentController : Controller
    {
        private readonly IStudentServices _services;
        public StudentController(IStudentServices service)
        {
            _services = service;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = _services.GetAllStudent();
            var emailTask = _services.SendEmail(model);

            Console.WriteLine("Send email task started");
            Console.WriteLine("Sending email....");

            var result = await emailTask;
            Console.WriteLine("Email sending task completed");

            return View(model);
        }

        //[HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult SingleStudent(int id)
        {
            var model = _services.GetSingleStudent(id);
            return View(model);
        }
    }
}
