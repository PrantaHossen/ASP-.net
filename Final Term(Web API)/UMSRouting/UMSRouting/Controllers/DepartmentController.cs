using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;
using UMSRouting.Models;
using UMSRouting.Models.ViewModel;

namespace UMSRouting.Controllers
{
    public class DepartmentController : ApiController
    {   //Database
        UMSEntities db = new UMSEntities();

        //Getting all Department Name 
        public List<DepartmentModel> Get()
        {
            var dept=new List<DepartmentModel>();
            foreach (var dep in db.Departments) 
            {
                var department = new DepartmentModel() 
                {
                    Dept_Id = dep.Dept_Id,
                    Dept_Name= dep.Dept_Name
                };
                dept.Add(department);
            }
            return dept;
        }

        public DepartmentModel Get(int id) 
        {
            var dept= db.Departments.FirstOrDefault(s=>s.Dept_Id==id);
            var department = new DepartmentModel() 
            {
                Dept_Id = dept.Dept_Id,
                Dept_Name = dept.Dept_Name
            };
            return department;
        }

        //Starting Custom API

        //Getting All Department Names
        [Route("api/department/names")]
        [HttpGet]
        public List<string> DepartNames()
        {
            var data = (from st
                       in db.Departments
                        select st.Dept_Name).ToList();

            return data;
        }
    }
}
