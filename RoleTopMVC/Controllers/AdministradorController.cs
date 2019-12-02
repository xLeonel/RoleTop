using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        public IActionResult Dashboard()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Administrador",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}