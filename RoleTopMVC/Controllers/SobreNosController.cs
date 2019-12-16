using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class SobreNosController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        DepoimentoRepository depoimentoRepository = new DepoimentoRepository();
        public IActionResult Index()
        {
            var depoimentosList = depoimentoRepository.ObterTodos();
            
            foreach (var item in depoimentosList)
            {
                var urlFoto = Directory.GetFiles(item.Cliente.URLFotoPerfil).FirstOrDefault();
                var urlRelativa = urlFoto.Replace(Directory.GetCurrentDirectory(), "").Replace("\\", "/").Replace("wwwroot", "");
                item.Cliente.URLFotoPerfil = urlRelativa;
            }

            return View(new BaseViewModel()
            {
                NomeView = "SobreNos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Depoimentos = depoimentosList,
            });
        }
    }
}