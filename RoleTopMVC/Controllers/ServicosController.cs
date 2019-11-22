using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Servicos";
            return View();
        }

        public IActionResult Casamento()
        {
            ViewData["NomeView"] = "Casamento";
            return View();
        }
    }
}