using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo
    {
        static UMSEntities db;

        static StudentRepo() {  db = new UMSEntities(); }

        public static List<Student> GetStudents() 
        {
            return db.Students.ToList();
        }

        public static  Student GetStudent(int id)
        {
            {
                var data = db.Students.FirstOrDefault(st => st.Student_Id == id);
                return data;

            }
        }

        public static string Edit(Student st)
        {
            var data = db.Students.FirstOrDefault(s =>s.Student_Id ==  st.Student_Id );
            db.Entry(data).CurrentValues.SetValues(st);
            db.SaveChanges();

            var msg = st + "Updated SuccessFully";
            return msg;
        }

        public static string Delete(Student st) 
        {
            var data = db.Students.FirstOrDefault(s => s.Student_Id == st.Student_Id);
            db.Students.Remove(data);
            db.SaveChanges();
            var msg = st + "Deleted SuccessFully";
            return msg;
        }
    }
}
