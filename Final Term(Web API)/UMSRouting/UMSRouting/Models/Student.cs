//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMSRouting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public System.DateTime Student_DOB { get; set; }
        public string Student_Gender { get; set; }
        public int Department_Id { get; set; }
        public decimal Student_CGPA { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
