using MidtermAssesment.DTOs;
using MidtermAssesment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidtermAssesment.Controllers
{
    public class UserController : Controller
    {
        MidAssesmentEntities db = new MidAssesmentEntities();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        //

        public ActionResult UpdateProfile() 
        { 
            return View(); 
        }


        ///Review area
        public ActionResult ReviewList()
        {
            var data = db.Reviews.ToList();
            return View(Convert(data));
 
        }

        [HttpGet]


        //for creating Review
        public ActionResult CreatReview() 
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult CreatReview(ReviewDTO s)
        {
            
            if (ModelState.IsValid)
            {
                var review = Convert(s);
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);
        }

        //For Editing Review

        [HttpGet]
        public ActionResult EditReview(int id)
        {
            var exobj = db.Reviews.Find(id);
            return View(exobj);
        }
        [HttpPost]
        public ActionResult EditReview(ReviewDTO s)
        {
            var exobj = db.Reviews.Find(s.ReviewID);
            exobj.User_Id = ((User)Session["user"]).User_Id;
            exobj.BookID = s.BookID;
            exobj.Contents = s.Contents;
            exobj.Timestamp = s.Timestamp;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
        

        //For Deleting Review

        
        [HttpGet]
        public ActionResult DeleteReview(int id)
        {
            var exobj = db.Reviews.Find(id);
            return View(exobj);
        }
        [HttpPost]
        public ActionResult DeleteReview(ReviewDTO s)
        {
            var exobj = db.Reviews.Find(s.ReviewID);
            exobj.User_Id = ((User)Session["user"]).User_Id;
            exobj.BookID = s.BookID;
            exobj.Contents = s.Contents;
            exobj.Timestamp = s.Timestamp;
            db.Reviews.Remove(exobj);
            db.SaveChanges();

            return RedirectToAction("Index");

        }




        ///Convert Function 
        public static ReviewDTO Convert(Review s)
        {

            return new ReviewDTO()
            {
                ReviewID = s.ReviewID,
                User_Id = s.User_Id,
                BookID = s.BookID,
                Contents = s.Contents,
                Timestamp = s.Timestamp
            };
        }
        public static Review Convert(ReviewDTO s)
        {
            return new Review()
            {
                ReviewID = s.ReviewID,
                User_Id = s.User_Id,
                BookID = s.BookID,
                Contents = s.Contents,
                Timestamp = s.Timestamp
            };
        }
        public static List<ReviewDTO> Convert(List<Review> review)
        {
            var list = new List<ReviewDTO>();
            foreach (var s in review)
            {
                var st = Convert(s);
                list.Add(st);
            }
            return list;
        }
    }
}