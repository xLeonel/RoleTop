using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class EventosController : AbstractController
    {
        EventoRepository eventoRepository = new EventoRepository();
        public IActionResult Index()
        {
            var eventosPub = eventoRepository.ObterPrivacidade(1);
            foreach (var item in eventosPub)
            {
                var urlFoto = Directory.GetFiles(item.URLFotoPerfil).FirstOrDefault();
                var urlRelativa = urlFoto.Replace(Directory.GetCurrentDirectory(), "").Replace("\\", "/").Replace("wwwroot", "");
                item.URLFotoPerfil = urlRelativa;
            }

            return View(new EventoViewModel()
            {
                NomeView = "Eventos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Eventos = eventosPub
            });
        }

        public IActionResult AtulizarFotoEvento(IFormCollection form)
        {
            var id = ulong.Parse(form["id"]); //*ARRUMAR ESSA GAMBIARRA INPUT(HIDDEN) MOSTRA NO F12 */

            var evento = eventoRepository.ObterPor(id);
            evento.Privacidade = (uint)PrivacidadeEvento.PÚBLICO;
            var urlFoto = $"wwwroot\\{PATH_FOTOSEVENTOS}\\{evento.Cliente.Email}\\{evento.NomeEvento}\\";
            GravarFoto(form.Files, urlFoto);
            evento.URLFotoPerfil = urlFoto;

            // var atualizar = eventoRepository.AtualizarFoto(id, urlFoto);
            var atualizarevento = eventoRepository.Atualizar(evento);

            return RedirectToAction("MeusEventos", "Login");
        }

        public async void GravarFoto(IFormFileCollection arquivos, string urlFoto)
        {
            foreach (var foto in arquivos)
            {
                System.IO.Directory.CreateDirectory(urlFoto).Create();
                var file = System.IO.File.Create(urlFoto + foto.FileName);
                await foto.CopyToAsync(file);
                file.Close();
            }
        }
    }
}