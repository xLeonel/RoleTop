using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ServicosController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Servicos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Casamento()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Casamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Corporativo()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Casamento",
                // NomeView = "Corporativo",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Debutante()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Casamento",
                // NomeView = "Debutante",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Outros()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Casamento",
                // NomeView = "Outros",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}