using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Validation.Pages.Model;

namespace Validation.Pages.Students
{
    public class CreateModel : PageModel
    {
        public Student Student { get; set; }

        public void OnGet()
        {

        }
    }
}