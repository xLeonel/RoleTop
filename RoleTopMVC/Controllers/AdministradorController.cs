using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Dashboard()
        {
            var user = clienteRepository.ObterPor(ObterUsuarioSession());
            var urlFoto = Directory.GetFiles(user.URLFotoPerfil).FirstOrDefault();
            var urlRelativa = urlFoto.Replace(Directory.GetCurrentDirectory(), "").Replace("\\", "/").Replace("wwwroot", "");

            return View(new EventoViewModel()
            {
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                FotoPerfil = urlRelativa
            });
        }

        public IActionResult EventosAdm()
        {
            var eventosPendente = eventoRepository.ObterEventoPor(0);
            var eventosAprovado = eventoRepository.ObterEventoPor(1);
            var eventosReprovado = eventoRepository.ObterEventoPor(2);
            var nomeEnum = Enum.GetNames(typeof(StatusEvento));
            var privacidadeEvento = Enum.GetNames(typeof(PrivacidadeEvento));

            return View(new EventoViewModel()
            {
                NomeView = "EventosAdm",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Eventos = eventosPendente,
                EventosAprovado = eventosAprovado,
                EventosReprovado = eventosReprovado,
                StatusEnum = nomeEnum,
                PrivacidadeEvento = privacidadeEvento
            });
        }

        public IActionResult Aprovar(ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint)StatusEvento.APROVADO;

            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("EventosAdm", "Administrador");
            }
            else
            {
                return View(new RespostaViewModel($"Não foi possível aprovar esse evento.")
                {
                    NomeView = "EventosAdm",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Recusar(ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint)StatusEvento.REPROVADO;

            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("EventosAdm", "Administrador");
            }
            else
            {
                return View(new RespostaViewModel($"Não foi possível aprovar esse evento.")
                {
                    NomeView = "EventosAdm",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
        public IActionResult Blacklist()
        {
            var clientesSemban = clienteRepository.ObterClientePor(0);
            var clientesBanidos = clienteRepository.ObterClientePor(1);
            var statusClientesEnum = Enum.GetNames(typeof(StatusClientes));

            return View(new EventoViewModel()
            {
                NomeView = "Blacklist",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Clientes = clientesSemban,
                ClientesBanido = clientesBanidos,
                StatusClienteEnum = statusClientesEnum
            });
        }

        public IActionResult Banir(string email)
        {
            var cliente = clienteRepository.ObterPor(email);
            cliente.StatusCliente = (uint) StatusClientes.BANIDO;

            if (clienteRepository.Atualizar(cliente))
            {
                return RedirectToAction("Blacklist","Administrador");
            }
            else
            {
                return View(new RespostaViewModel($"Não foi possível banir esse usuario.")
                {
                    NomeView = "Blacklist",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            } 
        }

        public IActionResult Desbanir(string email)
        {
            var cliente = clienteRepository.ObterPor(email);
            cliente.StatusCliente = (uint) StatusClientes.SEMBAN;

            if (clienteRepository.Atualizar(cliente))
            {
                return RedirectToAction("Blacklist","Administrador");
            }
            else
            {
                return View(new RespostaViewModel($"Não foi possível desbanir esse usuario.")
                {
                    NomeView = "Blacklist",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            } 
        }
    }
}