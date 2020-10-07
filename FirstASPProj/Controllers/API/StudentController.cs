using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPProj.Controllers.API
{
    [Route("api/[controller]")]//attribute route compulsory
    [ApiController]
    public class StudentController : ControllerBase
    {
        public List<StudentModel> Get()
        {
            return GetStudentModelsFromDb();
        }
        private List<StudentModel> GetStudentModelsFromDb()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { name = "Aavash", address = "satdobato" });
            students.Add(new StudentModel { name = "Sabin", address = "Bhaktapur" });
            students.Add(new StudentModel { name = "Bibke", address = "Jadibuti" });

            return students;
        }
    }
}
