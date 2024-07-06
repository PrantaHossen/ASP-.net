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
    public class DepartmentController : ApiController
    {
        UMSEntities db = new UMSEntities();

        //Get All dept using mapper
        [Route("api/department/names")]
        [HttpGet]
        public List<DepartmentModel> AllDept()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Department, DepartmentModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DepartmentModel>>(db.Departments.ToList());
            return data;
        }
    }
}
