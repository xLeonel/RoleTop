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
        public StatusEvento StatusEvento { get; set; }
        public string PacoteEvento {get;set;}


        public Evento()
        {
            this.NomeEvento = "RoleTop";
            this.Cliente = new Cliente();
            this.DiaEvento = DiaEvento;
            this.TipoEvento = TipoEvento;
            this.NumeroPessoas = NumeroPessoas;
            this.StatusEvento = (uint)StatusEvento.PENDENTE;
        }

    }
}