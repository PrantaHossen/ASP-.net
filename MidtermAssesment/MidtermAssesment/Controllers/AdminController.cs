using MidtermAssesment.DTOs;
using MidtermAssesment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidtermAssesment.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        MidAssesmentEntities db = new MidAssesmentEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Authorlist()
        {
            var data = db.Authors.ToList();
            return View(Convert(data));
        }


        [HttpGet]
        public ActionResult CreatAuthor() 
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreatAuthor(AuthorDTO a)
        {
            if (ModelState.IsValid)
            {
                var st = Convert(a);
                db.Authors.Add(st);
                db.SaveChanges();
                TempData["Msg"] = "Author Created Succesfully";
                return RedirectToAction("Index", "Admin");

            }
            return View(a);
        }



        //For Editing Review

        [HttpGet]
        public ActionResult EditAuthor(int id)
        {
            var exobj = db.Reviews.Find(id);
            return View(exobj);
        }
        [HttpPost]
        public ActionResult EditAuthor(AuthorDTO s)
        {
            var exobj = db.Authors.Find(s.AuthorID);
            
            exobj.AuthorID = s.AuthorID;
            exobj.Name = s.Name;
            exobj.Biography = s.Biography;
            db.SaveChanges();

            return RedirectToAction("Index");

        }


        //For Deleting Review


        [HttpGet]
        public ActionResult DeleteAuthor(int id)
        {
            var exobj = db.Authors.Find(id);
            return View(exobj);
        }
        [HttpPost]
        public ActionResult DeleteAuthor(AuthorDTO s)
        {
            var exobj = db.Authors.Find(s.AuthorID);
            exobj.AuthorID = s.AuthorID;
            exobj.Name = s.Name;
            exobj.Biography = s.Biography;
            db.Authors.Remove(exobj);
            db.SaveChanges();

            return RedirectToAction("Index");

        }




        ///Converting 

        public static AuthorDTO Convert(Author s)
        {

            return new AuthorDTO()
            {
                AuthorID = s.AuthorID,
                Name = s.Name,
                Biography = s.Biography,
            };
        }
        public static Author Convert(AuthorDTO s)
        {
            return new Author()
            {
                AuthorID = s.AuthorID,
                Name = s.Name,
                Biography = s.Biography,
            };
        }
        public static List<AuthorDTO> Convert(List<Author> book)
        {
            var list = new List<AuthorDTO>();
            foreach (var s in book)
            {
                var st = Convert(s);
                list.Add(st);
            }
            return list;
        }
    }
}