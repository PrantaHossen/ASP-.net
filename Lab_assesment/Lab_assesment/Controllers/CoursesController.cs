using Lab_assesment.DTOs;
using Lab_assesment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_assesment.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            DotNetEntities db = new DotNetEntities();
            var data = db.Courses.ToList();
            var converted = Convert(data);
            return View(converted);
        }

        [HttpGet]
        public ActionResult Create()
        {
            DotNetEntities db = new DotNetEntities();
            return View();
        }
        [HttpPost]
        public ActionResult Create(CoursesDTO courses)
        {
            DotNetEntities db = new DotNetEntities();
            if(ModelState.IsValid)
            {
                var course=Convert(courses);
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courses);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult Edit(Cours course)
        { 
            return View(); 
        }


        //DTO portion
        public static CoursesDTO Convert(Cours s)
        {
            return new CoursesDTO()
            {
                Id = s.Id,
                Title = s.Title,
                CreditHr = s.CreditHr,
                Type = s.Type,
            };
        }
        public static Cours Convert(CoursesDTO s)
        {
            return new Cours()
            {
               Id=s.Id,
               Title=s.Title,
               CreditHr=s.CreditHr,
               Type=s.Type,
            };
        }
        public static List<CoursesDTO> Convert(List<Cours> Courses)
        {
            var list = new List<CoursesDTO>();
            foreach (var s in Courses)
            {
                var st = Convert(s);
                list.Add(st);
            }
            return list;
        }
    }

}