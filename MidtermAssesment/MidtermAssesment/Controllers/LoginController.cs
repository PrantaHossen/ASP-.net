using MidtermAssesment.DTOs;
using MidtermAssesment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidtermAssesment.Controllers
{
    public class LoginController : Controller
    {
        MidAssesmentEntities db = new MidAssesmentEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginDTO l)
        {
            if (ModelState.IsValid)
            {
                var user = (from u in db.Users
                            where u.Email.Equals(l.Email) &&
                            u.Password.Equals(l.Password)
                            select u).SingleOrDefault();
                if (user == null)
                {
                    TempData["Msg"] = "Credential Not Found";
                    return RedirectToAction("Index");
                }
                Session["user"] = user;
                TempData["Msg"] = "Login Successfull";
                if (user.Type.Equals("Member"))
                {
                    return RedirectToAction("Index", "User");
                }
                else 
                {
                    return RedirectToAction("Index", "Admin");
                }
                
                
            }
            return RedirectToAction("Index", "Login");
        }
    }
}
