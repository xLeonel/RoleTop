using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Faq";
            return View();
        }
    }
}