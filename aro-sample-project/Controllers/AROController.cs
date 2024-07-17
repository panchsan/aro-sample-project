using Microsoft.AspNetCore.Mvc;

namespace aro_sample_project.Controllers
{
    public class AROController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
