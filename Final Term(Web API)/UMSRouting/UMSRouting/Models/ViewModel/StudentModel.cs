using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UMSRouting.Models.ViewModel
{
    public class StudentModel
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Cgpa { get; set; }
        public int Department_Id { get; set; }

        public virtual DepartmentModel Department { get; set; }
    }
}