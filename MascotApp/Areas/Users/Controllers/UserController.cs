using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.Areas.Users.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
