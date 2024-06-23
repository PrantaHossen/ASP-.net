using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_assesment.DTOs
{
    public class CoursesDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string CreditHr {  get; set; }
        [Required]
        public string Type {  get; set; }
    }
}