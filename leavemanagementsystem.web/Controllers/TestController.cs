using leavemanagementsystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace leavemanagementsystem.web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Gibson of MVC mastery",
                DateOfBirth = new DateTime(1993,10,23)
            };
            return View(data);
        }
    }
}
