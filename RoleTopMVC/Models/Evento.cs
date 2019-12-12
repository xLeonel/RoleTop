using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Evento
    {
        public Cliente Cliente { get; set; }
        public DateTime DiaEvento { get; set; }
        public string TipoEvento { get; set; }
        public uint NumeroPessoas { get; set; }
        public string NomeEvento { get; set; }
        public uint Status { get; set; }
        public string PacoteEvento { get; set; }
        public ulong Id { get; set; }
        public uint Privacidade { get; set; }
        public string URLFotoPerfil { get; set; }

        public Evento()
        {
            this.NomeEvento = "RoleTop";
            this.Cliente = new Cliente();
            this.DiaEvento = DiaEvento;
            this.TipoEvento = TipoEvento;
            this.NumeroPessoas = NumeroPessoas;
            this.Status = (uint)StatusEvento.PENDENTE;
            this.Id = 0;
            this.Privacidade = (uint)PrivacidadeEvento.PRIVADO;
        }
    }
}