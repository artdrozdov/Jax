using Microsoft.AspNetCore.Mvc;

namespace Jax.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
