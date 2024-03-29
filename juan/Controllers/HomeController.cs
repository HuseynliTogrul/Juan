using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace juan.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
