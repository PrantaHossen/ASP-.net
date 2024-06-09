using DataView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DataView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PersonalInfo personalInfo = new PersonalInfo();
            personalInfo.Name = "Pranta Hossen";
            personalInfo.Email = "prantahossen@gmail.com";
            personalInfo.Phone = 01784848766;
            personalInfo.Degree = "BSc in CSE";
            personalInfo.Expertise = "Laravel";

            ViewBag.PersonalInfo = new PersonalInfo[] { personalInfo };
            return View();
        }
        public ActionResult Education()
        {
            EducationInfo HSC = new EducationInfo()
            {
                Year=2020,
                Group="SCIENCE",
                Ins="Chittagong Municipal Model High School"
            };
            EducationInfo SSC = new EducationInfo()
            {
                Year = 2018,
                Group = "SCIENCE",
                Ins = "Chittagong Municipal Model High School"
            };

            ViewBag.EducationInfo = new EducationInfo[] {HSC,SSC};

            return View();
        }
        public ActionResult Projects()
        {
            ProjectsInfo projectsInfo1 = new ProjectsInfo()
            {
                Title = "Hotel Management System",
                Descrition = "Descrition1",
                Course="Java"
            };
            ProjectsInfo projectsInfo2 = new ProjectsInfo()
            {
                Title = "Hotel Management System",
                Descrition = "Descrition2",
                Course = "Java"
            };
            ProjectsInfo projectsInfo3 = new ProjectsInfo()
            {
                Title = "Hotel Management System",
                Descrition = "Descrition3",
                Course = "Java"
            };

            ViewBag.ProjectsInfo = new ProjectsInfo[] { projectsInfo1, projectsInfo2, projectsInfo3 };
            return View();
        }
        public ActionResult Certification()
        {
            return View();
        }
        public ActionResult Refer()
        {
            ReferInfo referInfo1 = new ReferInfo() 
            {
                Name="ABCD",
                Designation="Project Manager"
            };
            ReferInfo referInfo2 = new ReferInfo()
            {
                Name = "XYZ",
                Designation = "Software Developer"
            };

            ViewBag.ReferInfo = new ReferInfo[] {referInfo1,referInfo2};
            return View();
        }

    }
}