using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Validation.Pages.Model;
using Microsoft.AspNetCore.Http;

namespace Validation.Pages
{
    public class CreateStudentsModel : PageModel
    {

        private readonly CollegeContext _db;


        public CreateStudentsModel(CollegeContext db)
        {
            _db = db;
        }


        public Student Student { get; set; }



        public void OnGet()
        {

        }



        public async Task<IActionResult> OnAsyncPost()
        {
            
            
                _db.Students.Add(Student);
                await _db.SaveChangesAsync();
                return RedirectToPage("ListStudents");
            

          

        }
    }
}