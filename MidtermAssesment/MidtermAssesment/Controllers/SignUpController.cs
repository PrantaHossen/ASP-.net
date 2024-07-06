using MidtermAssesment.DTOs;
using MidtermAssesment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidtermAssesment.Controllers
{
    public class SignUpController : Controller
    {
        MidAssesmentEntities db = new MidAssesmentEntities();
        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(SignUpDTO s)
        {
            if (ModelState.IsValid)
            {
                var user = Convert(s);
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index", "Login");
            }
            return View(s);

        }





        public static SignUpDTO Convert(User s)
        {

            return new SignUpDTO()
            {
                UserName = s.UserName,
                Email = s.Email,
                Password = s.Password,
                User_Id = s.User_Id
            };
        }
        public static User Convert(SignUpDTO s)
        {
            return new User()
            {
                UserName = s.UserName,
                Email = s.Email,
                Password = s.Password,
                User_Id = s.User_Id
            };
        }
        public static List<SignUpDTO> Convert(List<User> users)
        {
            var list = new List<SignUpDTO>();
            foreach (var s in users)
            {
                var st = Convert(s);
                list.Add(st);
            }
            return list;
        }
    }

    
}