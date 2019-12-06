using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
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
            var eventosPendente = eventoRepository.ObterEventoPor(0);
            var eventosAprovado = eventoRepository.ObterEventoPor(1);
            var eventosReprovado = eventoRepository.ObterEventoPor(2);

            return View(new EventoViewModel()
            {
                NomeView = "EventosAdm",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Eventos = eventosPendente,
                EventosAprovado = eventosAprovado,
                EventosReprovado = eventosReprovado
            });
        }

        public IActionResult Aprovar(ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.APROVADO;

            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("EventosAdm", "Administrador");
            }
            else
            {
                return View(new RespostaViewModel($"Não foi possível aprovar esse pedido."){
                    NomeView = "EventosAdm",
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
                return RedirectToAction("EventosAdm", "Administrador");
            }
            else
            {
                return View(new RespostaViewModel($"Não foi possível aprovar esse pedido."){
                    NomeView = "EventosAdm",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}