using System.Collections.Generic;
using Gradebook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gradebook.Controllers
{
    public class GradebookController : Controller
    {
        // GET
        public IActionResult Index()
        {
            ViewData["students"] = Database.shared.students;
            return View();
        }
    }
}