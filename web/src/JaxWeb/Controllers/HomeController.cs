using Microsoft.AspNetCore.Mvc;

namespace JaxWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
