using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class EventoViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public Cliente Cliente {get;set;}
        public List<Evento> Pacotes {get;set;}
       

        public EventoViewModel()
        {
            this.Cliente = new Cliente();
            this.Eventos = new List<Evento>();
            this.Pacotes = new List<Evento>();
        }
    }
}