using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPProj.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage ="Please enter full name")]
        [Display(Name = "Full Name")]
        public string name { get; set; }
        [Display(Name ="Full Address")]
        public string address { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string email { set; get; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Password not matching")]
        public string confirmPassword { get; set; }
    }
}
