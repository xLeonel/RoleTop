using System.Collections.Generic;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;

namespace RoleTopMVC.ViewModels
{
    public class BaseViewModel
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public string NomeView { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioEmail { get; set; }
        public string Celular {get;set;}
        public string FotoPerfil {get;set;}
        public List<Depoimento> Depoimentos {get;set;}
        
        public string PrimeiroNome()
        {
            var nomeCompleto = this.UsuarioNome.ToLower();
            string[] nomeSeparado = nomeCompleto.Split(' ');
            string primeiroNome = nomeSeparado[0];
            primeiroNome = primeiroNome.Length > 1 ? char.ToUpper(primeiroNome[0]) + primeiroNome.Substring(1) : primeiroNome.ToUpper();
            return primeiroNome;
        }
    }
}