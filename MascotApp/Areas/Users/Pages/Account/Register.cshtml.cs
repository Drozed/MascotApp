using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso.Areas.Users.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Curso.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }

            public string ErrorMessage { get; set; }

        } 
    }
}
