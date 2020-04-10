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
            List<Student> students = new List<Student>();
            students.Add(new Student("Ashanti Hirst", "08-12-2000", "CSSE-1704K"));
            students.Add(new Student("Orson Sexton", "19-08-1999", "CSSE-1704K"));
            students.Add(new Student("Shanelle Greene", "14-01-2001", "CSSE-1704K"));
            students.Add(new Student("Clay Wise", "02-02-2001", "CSSE-1704K"));
            students.Add(new Student("Aiesha Moyer", "06-11-1999", "CSSE-1704K"));
            students.Add(new Student("Rares Gardner", "23-04-2001", "CSSE-1704K"));
            students.Add(new Student("Harley Hibbert", "31-05-2001", "CSSE-1704K"));
            students.Add(new Student("Madelaine Mcnamara", "11-10-1999", "CSSE-1704K"));
            students.Add(new Student("Ellis Benton", "13-09-2000", "CSSE-1704K"));
            students.Add(new Student("Bethanie Barnett", "04-09-1999", "CSSE-1704K"));

            ViewData["students"] = students;
            return View();
        }
    }
}