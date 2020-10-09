using FirstASPProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPProj.Services
{
    public class StudentServices : IStudentServices
    {
        public List<StudentModel> GetAllStudent()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { id = 1, name = "Aavash", address = "satdobato" });
            students.Add(new StudentModel { id = 2, name = "Sabin", address = "Bhaktapur" });
            students.Add(new StudentModel { id = 3, name = "Bibke", address = "Jadibuti" });

            return students;
        }
        public StudentModel GetSingleStudent(int id)
        {

            return new StudentModel { id = id, name = "Aavash", address = "satdobato" };

            /*List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { id = 0, name = "Aavash", address = "satdobato" });
            students.Add(new StudentModel { id = 1, name = "Sabin", address = "Bhaktapur" });
            students.Add(new StudentModel { id = 2, name = "Bibke", address = "Jadibuti" });*/


            /*int exist = findIndex(students,id);

            if (exist >= 0)
            {
                return students[exist];
            }
            else
            {
                return null;
            }*/
        }
        /*private int findIndex(List<StudentModel> students,int id)
        {
            for(int i = 0; i < students.Count; i++)
            {
                if (students[i].id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }*/

        public async Task<int> SendEmail(List<StudentModel> model)
        {
            await Task.Delay(5000);
            foreach (var std in model)
            {
                Console.WriteLine($"Email sent to {std.name}");
            }
            return 1;
        }
    }
}
