using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            try
            {
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["senha"],
                    form["email"],
                    form["celular"],
                    uint.Parse(form["cpf"]),
                    DateTime.Parse(form["data-nascimento"]));

                cliente.TipoUsuario = (uint)TipoUsuario.CLIENTE;

                cliente.URLFotoPerfil =  $"wwwroot\\{PATH_FOTOS}\\fotopadrao\\";
                
                if (clienteRepository.Inserir(cliente))
                {
                    return View("Sucesso", new RespostaViewModel()
                    {
                        NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                    });
                }
                else
                {
                    return View("Erro", new RespostaViewModel()
                    {
                        NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                    });
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
    }
}