using FirstASPProj.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPProj.Services
{
    public class StudentServices : IStudentServices
    {
        public List<StudentModel> GetAllStudent()
        {
            List<StudentModel> students = new List<StudentModel>();
            /*students.Add(new StudentModel { id = 1, name = "Aavash", address = "satdobato" });
            students.Add(new StudentModel { id = 2, name = "Sabin", address = "Bhaktapur" });
            students.Add(new StudentModel { id = 3, name = "Bibke", address = "Jadibuti" });
*/
            var conStr = "Data Source=DESKTOP-KDHNFAA;initial catalog=Orchid;integrated security=True;MultipleActiveResultSets=True";
            
            /*var cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from student";*/
            var sql = "Select * from student";

            /*conn.Open();*/
            /*SqlDataReader result=cmd.ExecuteReader();*/

            using (var conn = new SqlConnection(conStr))
            {
                var adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);




                /*while (result.Read())*/
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    StudentModel std = new StudentModel
                    {
                        /*id = (int)result["Id"],
                        name = result["Name"].ToString(),
                        email = result["Email"].ToString(),
                        address = result["Address"].ToString()*/
                        id = (int)row["Id"],
                        name = row["Name"].ToString(),
                        email = row["Email"].ToString(),
                        address = row["Address"].ToString()
                    };
                    students.Add(std);
                }

            }

            /*conn.Close();
            conn.Dispose();*/


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
