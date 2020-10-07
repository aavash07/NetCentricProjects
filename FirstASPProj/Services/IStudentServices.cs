using FirstASPProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPProj.Services
{
    public interface IStudentServices
    {
        List<StudentModel> GetAllStudent();
        StudentModel GetSingleStudent(int id);
    }
}
