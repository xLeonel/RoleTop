using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        EventoRepository eventoRepository = new EventoRepository();
        public IActionResult Dashboard()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult EventosAdm()
        {
            return View(new EventoViewModel()
            {
                NomeView = "EventosAdm",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Eventos = eventoRepository.ObterTodos()
            });
        }

        public IActionResult Aprovar(ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.APROVADO;

            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View(new RespostaViewModel($"Não foi possível aprovar esse pedido."){
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Recusar(ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.REPROVADO;

            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View(new RespostaViewModel($"Não foi possível aprovar esse pedido."){
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}