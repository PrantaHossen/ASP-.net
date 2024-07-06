using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidtermAssesment.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[a-z0-9]+(\.[a-z0-9]+)*@[a-z0-9]+(\.[a-z]+)+$", ErrorMessage = "Email must be in lowercase, contain '@', and must not have special characters or spaces, except dots.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]

        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]

        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one number, and one special character.")]
        public string Password { get; set; }
    }
}