using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MidtermAssesment.DTOs
{
    public class ReviewDTO
    {
        public int ReviewID { get; set; }
        public int User_Id { get; set; }
        public int BookID { get; set; }
        public string Contents { get; set; }
        public string Timestamp { get; set; }
    }
}