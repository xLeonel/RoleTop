using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "cliente_email";
        protected const string SESSION_CLIENTE_NOME = "cliente_nome";
        protected const string SESSION_CLIENTE_TIPO = "cliente_tipo";
        protected const string PATH_FOTOS = "fotouser\\fotos";
        protected const string PATH_FOTOSEVENTOS = "fotoevento\\fotos";
        protected string ObterUsuarioSession()
        {
            var email = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if (!string.IsNullOrEmpty(email))
            {
                return email;
            } 
            else
            {
                return "";
            }
        }
        protected string ObterUsuarioNomeSession()
        {
            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if (!string.IsNullOrEmpty(nome))
            {
                return nome;
            } 
            else
            {
                return "";
            }
        }
        protected string ObterUsuarioTipoSession()
        {
            var tipoUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                return tipoUsuario;
            } 
            else
            {
                return "";
            }
        }
    }
}