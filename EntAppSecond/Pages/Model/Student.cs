using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Validation.Pages.Model
{
    public class Student
    {

        [Required]
        [RegularExpression(@"^(s|S)\d{7}$", ErrorMessage ="ID Must be of format s1234567")]
        public string StudentID { get; set; } = "";


        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"\S{2,}", ErrorMessage ="First Name must be at least two characters")]
        public string FirstName { get; set; } = "";


        [Required]
        [RegularExpression(@"\S{3,}", ErrorMessage = "Last Name must be at least three characters")]
        public string LastName { get; set; } = "";


        //[DataType(DataType.Date)]
        //public DateTime DOB { get; set; }


        //[Range(1, 100, ErrorMessage = "You must be registered for at least one module")]
        //public int NrModules { get; set; }


        //[Range(50, 250, ErrorMessage ="Height must be between 50 and 250 cms, sorry!!")]
        //public int Height { get; set; }


        //[DataType(DataType.EmailAddress)]
        //public EmailAddressAttribute Email { get; set; }


        //[Compare("Email")]
        //public EmailAddressAttribute EmailConfirm { get; set; }


        public Student()
        {

        }

    }
}
