using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public string Celular {get;set;}
        public uint Cpf {get;set;}
        public DateTime DataNascimento {get;set;}
        public uint TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string Nome, string Senha, string Email, string Celular, uint Cpf, DateTime DataNascimento)
        {
            this.Nome = Nome;
            this.Senha = Senha;
            this.Email = Email;
            this.Celular = Celular;
            this.Cpf = Cpf;
            this.DataNascimento = DataNascimento;
        }
    }
}