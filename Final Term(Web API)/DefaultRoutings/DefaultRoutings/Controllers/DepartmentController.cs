using DefaultRoutings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DefaultRoutings.Controllers
{
    public class DepartmentController : ApiController
    {
        public List<DepartmentModel> Get()
        {
            List<DepartmentModel> dept = new List<DepartmentModel>();

            for (int i = 0; i < 10; i++) {
                dept.Add(new DepartmentModel()
                { 
                    Dept_Id = i+1,
                    Dept_Name= "Department Name " +i
                    
                });
            }
            return dept;
        }

        public string Post(DepartmentModel d)
        {
            List<DepartmentModel> dept = new List<DepartmentModel>();

            for (int i = 0; i < 10; i++)
            {
                dept.Add(new DepartmentModel()
                {
                    Dept_Id = i + 1,
                    Dept_Name = "Department Name " + i

                });
            }
            dept.Add(d);
            return "New Department Added SuccessFully";
        }

        public string Put(int d, DepartmentModel dept)
        {
            return "This is from Put Method";
        }
        public string Delete()
        {
            return "This is from Delete Method";
        }
    }
}
