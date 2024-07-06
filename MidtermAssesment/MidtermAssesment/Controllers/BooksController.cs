using MidtermAssesment.DTOs;
using MidtermAssesment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidtermAssesment.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books

        MidAssesmentEntities db = new MidAssesmentEntities();
        public ActionResult Index()
        {
            var data = db.Books.ToList();
            return View(Convert(data));
            
        }

        [HttpGet]
        public ActionResult CreateBooksDetails()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBooksDetails(BooksDTO books)
        {
            if (ModelState.IsValid)
            {
                var st = Convert(books);
                db.Books.Add(st);
                db.SaveChanges();
                return RedirectToAction("Index","Admin");
            }
            return View(books);
        }








        public static BooksDTO Convert(Book s)
        {

            return new BooksDTO()
            {
                BookID = s.BookID,
                Title = s.Title,
                Genre = s.Genre,
                AuthorID = s.AuthorID,
                PublicationDate = s.PublicationDate
            };
        }
        public static Book Convert(BooksDTO s)
        {
            return new Book()
            {
                BookID = s.BookID,
                Title = s.Title,
                Genre = s.Genre,
                AuthorID = s.AuthorID,
                PublicationDate = s.PublicationDate
            };
        }
        public static List<BooksDTO> Convert(List<Book> book)
        {
            var list = new List<BooksDTO>();
            foreach (var s in book)
            {
                var st = Convert(s);
                list.Add(st);
            }
            return list;
        }
    }
}