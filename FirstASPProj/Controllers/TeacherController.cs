using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPProj.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPProj.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            var model = GetTeacherModelsDB();
            return View(model);
        }
        private List<TeacherModel> GetTeacherModelsDB()
        {
            List<TeacherModel> teachers = new List<TeacherModel>();
            teachers.Add(new TeacherModel { name = "Ram", subject = "math" });
            teachers.Add(new TeacherModel { name = "Hari", subject = "science" });
            teachers.Add(new TeacherModel { name = "shyam", subject = "nepali" });
            return teachers;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
