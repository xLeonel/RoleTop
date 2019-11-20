using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class SobreNosController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "SobreNos";
            return View();
        }
    }
}