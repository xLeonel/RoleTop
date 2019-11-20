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
    }
}