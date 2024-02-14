using Microsoft.AspNetCore.Mvc;

namespace HTML_CSS.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
            
        [Route("teste")]
        public IActionResult Teste()
        {
            return View();
        }
    }
}
