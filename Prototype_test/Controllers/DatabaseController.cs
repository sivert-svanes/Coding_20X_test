using Microsoft.AspNetCore.Mvc;
using Prototype_test.Models;

namespace Prototype_test.Controllers
{
    public class DatabaseController : Controller
    {
        public IActionResult DatabaseIndex()
        {
            // Assuming _obstacles is public static in DatabaseModel
            return View(DatabaseModel._obstacles);
        }
    }
}
