using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class FaqController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Faq",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}