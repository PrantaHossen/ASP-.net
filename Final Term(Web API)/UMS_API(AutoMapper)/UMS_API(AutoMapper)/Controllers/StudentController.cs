using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UMS_API_AutoMapper_.Models;
using UMS_API_AutoMapper_.Models.ViewModel;

namespace UMS_API_AutoMapper_.Controllers
{
    
    public class StudentController : ApiController
    {
        UMSEntities db = new UMSEntities();

        //Mapper Tamplate
        /*var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Student, StudentModel>();
            cfg.CreateMap<Department, DepartmentModel>();
        });
        var mapper = new Mapper(config);*/

        //Get All Students Using Mapper
        [Route("api/student/List")]
        [HttpGet]
        public List<StudentModel>GetALLStudenta()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student,StudentModel>();
                cfg.CreateMap<Department,DepartmentModel>();
            });
            var mapper= new Mapper(config);
            var data = mapper.Map<List<StudentModel>>(db.Students.ToList());

            return data;
        }

    }
}
