using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class LoginController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private EventoRepository eventoRepository = new EventoRepository();
        private TipoEventoRepository tipoEventoRepository = new TipoEventoRepository();
        private TipoPacoteRepository tipoPacoteRepository = new TipoPacoteRepository();

        [HttpGet] //*PEGAR DADOS*/
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost] //*ENVIAR DADOS*/
        public IActionResult Index(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("==================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("==================");

                var emailUser = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(emailUser);

                if (cliente != null)
                {
                    if (cliente.Senha.Equals(senha))
                    {
                        switch (cliente.TipoUsuario)
                        {
                            case (uint)TipoUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, emailUser);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());

                                return RedirectToAction("Dashboard", "Login");
                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, emailUser);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());

                                return RedirectToAction("Dashboard", "Administrador");
                        }

                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }

                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {emailUser} não encontrado"));
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }

        public IActionResult Dashboard()
        {
            return View(new RespostaViewModel()
            {
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult MeusEventos()
        {
            var emailUsuario = ObterUsuarioSession();
            var eventosCliente = eventoRepository.ObterTodosPorCliente(emailUsuario);
            var nomeEnum = Enum.GetNames(typeof(StatusEvento));

            return View(new EventoViewModel()
            {
                NomeView = "MeusEventos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Eventos = eventosCliente,
                Cliente = clienteRepository.ObterPor(ObterUsuarioSession()),
                StatusEnum = nomeEnum
            });
        }

        public IActionResult SolicitarEventos()
        {
            var usuarioLogado = ObterUsuarioSession();

            if (string.IsNullOrEmpty(usuarioLogado))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View(new EventoViewModel()
                {
                    NomeView = "SolicitarEventos",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession(),
                    Eventos = tipoEventoRepository.ObterTodos(),
                    Cliente = clienteRepository.ObterPor(ObterUsuarioSession()),
                    Pacotes = tipoPacoteRepository.ObterTodos()
                });
            }

        }

        public IActionResult RegistrarEvento(IFormCollection form)
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
            evento.PacoteEvento = form["pacoteEvento"];

            if (eventoRepository.Inserir(evento))
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "SolicitarEventos",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "SolicitarEventos",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult RecuperarSenha()
        {
            return View(new EventoViewModel()
            {
                NomeView = "RecuperarSenha",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult RecuperarSenhaMetodo(IFormCollection form)
        {
            string emailDestinatario = form["email"];
            var bolianUser = clienteRepository.ObterPor(emailDestinatario);
            if (bolianUser == null)
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "RecuperarSenhaMetodo",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

            var bolian = EnviarEmail(emailDestinatario);

            if (bolian)
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "RecuperarSenhaMetodo",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "RecuperarSenhaMetodo",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public bool EnviarEmail(string emailDestinatario)
        {
            var usuario = clienteRepository.ObterPor(emailDestinatario);
            try
            {
                // Estancia da Classe de Mensagem
                MailMessage _mailMessage = new MailMessage();
                // Remetente
                _mailMessage.From = new MailAddress("roletop.senai@gmail.com");

                // Destinatario seta no metodo abaixo

                //Contrói o MailMessage
                _mailMessage.CC.Add(emailDestinatario);
                _mailMessage.Subject = "Recuperar Senha";
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = $"<b>Olá você pediu sua senha?</b><p>Sua senha: {usuario.Senha}</p>";

                //CONFIGURAÇÃO COM PORTA
                SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));

                //CONFIGURAÇÃO SEM PORTA
                // SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

                // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("roletop.senai@gmail.com", "senai@132");

                _smtpClient.EnableSsl = true;

                _smtpClient.Send(_mailMessage);

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public IActionResult Configuracoes()
        {
            return View(new EventoViewModel()
            {
                NomeView = "Configuracoes",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult MudarSenha()
        {
            return View(new EventoViewModel()
            {
                NomeView = "MudarSenha",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult MudarSenhaMetodo(IFormCollection form)
        {
            var senha = form["senha"];
            var senhaConfirm = form["senha-confirm"];
            var userEmail = ObterUsuarioSession();
            var user = clienteRepository.ObterPor(userEmail);

            if (senha != senhaConfirm)
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "RecuperarSenhaMetodo",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                var atualizar = clienteRepository.AtualizarSenha(userEmail,senhaConfirm);
                if (atualizar)
                {
                    return View("Sucesso", new RespostaViewModel()
                    {
                        NomeView = "RecuperarSenhaMetodo",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                    });
                }
                else
                {
                    return View("Erro", new RespostaViewModel()
                    {
                        NomeView = "RecuperarSenhaMetodo",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                    });
                }
            }


        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}