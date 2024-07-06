using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UMSRouting.Models.ViewModel
{
    public class StudentModel
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public System.DateTime Student_DOB { get; set; }
        public string Student_Gender { get; set; }
        public int Department_Id { get; set; }
        public decimal Student_CGPA { get; set; }

        public virtual DepartmentModel Department { get; set; }
    }
}