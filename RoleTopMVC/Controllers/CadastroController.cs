using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
             ViewData["NomeView"] = "Cadastro";
            return View();
        } 
    }
}