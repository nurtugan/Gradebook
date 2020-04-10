using Microsoft.AspNetCore.Mvc;

namespace Gradebook.Controllers
{
    public class GradebookController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}