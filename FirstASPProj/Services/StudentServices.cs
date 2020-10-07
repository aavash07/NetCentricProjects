using FirstASPProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPProj.Services
{
    public class StudentServices:IStudentServices
    {
        public List<StudentModel> GetAllStudent()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { name = "Aavash", address = "satdobato" });
            students.Add(new StudentModel { name = "Sabin", address = "Bhaktapur" });
            students.Add(new StudentModel { name = "Bibke", address = "Jadibuti" });

            return students;
        }
    }
}
