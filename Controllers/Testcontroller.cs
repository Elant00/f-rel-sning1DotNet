using Microsoft.AspNetCore.Mvc;

namespace föreläsning1DotNet.Controllers
{
    public class Testcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
