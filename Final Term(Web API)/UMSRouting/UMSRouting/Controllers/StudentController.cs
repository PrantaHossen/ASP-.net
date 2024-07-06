using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Serialization;
using UMSRouting.Models;
using UMSRouting.Models.ViewModel;

namespace UMSRouting.Controllers
{
    public class StudentController : ApiController
    {
        //Database
        UMSEntities db = new UMSEntities();

        //Showing all the students from Students Table
        public List<StudentModel> Get()
        {
            var students = new List<StudentModel>();
            foreach(var student in db.Students)
            {
                var st=new StudentModel() 
                {
                    Student_Id= student.Student_Id,
                    Student_Name = student.Student_Name,
                    Student_Gender = student.Student_Gender,
                    Student_DOB = student.Student_DOB,
                    Student_CGPA = student.Student_CGPA,
                    Department_Id= student.Department_Id,
                };
                students.Add(st);
            }
            return students;
        }

        //Getting Student Imformation by there Student_Id

        public StudentModel Get(int id)
        {
            var student = db.Students.FirstOrDefault(st => st.Student_Id == id);
            var students = new StudentModel()
            {
                Student_Id = student.Student_Id,
                Student_Name = student.Student_Name,
                Student_Gender = student.Student_Gender,
                Student_DOB = student.Student_DOB,
                Student_CGPA = student.Student_CGPA,
                Department_Id = student.Department_Id,
            };
            return students;
        }

        //Starting Custom API


        //Getting All students Names 
        [Route("api/student/names")]
        [HttpGet]
        public List<string> StudentsName()
        {
            var data = (from st 
                       in db.Students 
                       select st.Student_Name).ToList();

            return data;
        }

        //Creating a Student Without Model
        [Route("api/student/Create")]
        [HttpPost]
        public string CreateStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            var msg = "Added Succesfully";
            return msg;
        }
    }
}
