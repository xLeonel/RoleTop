using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Login";
            return View();
        }
    }
}