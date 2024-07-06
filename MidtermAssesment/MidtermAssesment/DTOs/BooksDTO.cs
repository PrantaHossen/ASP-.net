using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MidtermAssesment.DTOs
{
    public class BooksDTO
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string Genre { get; set; }
        public System.DateTime PublicationDate { get; set; }
    }
}