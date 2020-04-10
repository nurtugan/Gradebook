using Gradebook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gradebook.Controllers
{
    public class StudentDetails : Controller
    {
        // GET
        public IActionResult Details(string hash)
        {
            if (Database.shared?.students != null)
                foreach (var student in Database.shared.students)
                {
                    if (student.Hash.Equals(hash))
                    {
                        ViewData["student"] = student;
                    }
                    
                }

            return View("StudentDetails");
        }
    }
}