using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ContatoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        EventoRepository eventoRepository = new EventoRepository();
        TipoEventoRepository tipoEventoRepository = new TipoEventoRepository();
        OrcamentoRepository orcamentoRepository = new OrcamentoRepository();
        PerguntaFaqRepository perguntaFaqRepository = new PerguntaFaqRepository();
        public IActionResult Index()
        {
           return View(new EventoViewModel()
            {
                NomeView = "Contato",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Eventos = tipoEventoRepository.ObterTodos(),
                Perguntas = perguntaFaqRepository.ObterTodos()
            });
        }

        public IActionResult SolicitarOrçamento(IFormCollection form)
        {
            Evento evento = new Evento();

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Email = form["email"],
                Celular = form["celular"]
            };

            evento.Cliente = cliente;
            evento.DiaEvento = DateTime.Parse(form["diaEvento"]);
            evento.TipoEvento = form["tipoEvento"];
            evento.NumeroPessoas = uint.Parse(form["numeroConvidados"]);
            evento.NomeEvento = form["nomeEvento"];

            if (orcamentoRepository.Inserir(evento))
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Contato",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Contato",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}