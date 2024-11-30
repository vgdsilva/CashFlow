using Microsoft.AspNetCore.Mvc;

namespace FluxoDeCaixa.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
