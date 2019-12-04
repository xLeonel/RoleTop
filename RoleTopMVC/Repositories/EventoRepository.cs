using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class EventoRepository : RepositoryBase
    {
        private const string PATH = "Database/Evento.csv";

        public EventoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

         public bool Inserir(Evento evento)
        {
            var linha = new string[] { PrepararRegistroCSV(evento) };
            File.AppendAllLines(PATH, linha);

            return true;            
        }

        private string PrepararRegistroCSV(Evento evento)
        {
            return $"evento_nome={evento.NomeEvento};cliente_nome={evento.Cliente.Nome};cliente_email={evento.Cliente.Email};cliente_celular={evento.Cliente.Celular};dia_evento={evento.DiaEvento};tipo_evento={evento.TipoEvento};quantidade_pessoas={evento.NumeroPessoas}";
        }

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> eventos = new List<Evento>();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                
                evento.NomeEvento = ExtrairValorDoCampo("evento_nome", linha);
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                evento.Cliente.Celular = ExtrairValorDoCampo("cliente_celular", linha);
                evento.DiaEvento = DateTime.Parse(ExtrairValorDoCampo("dia_evento", linha));
                evento.TipoEvento = ExtrairValorDoCampo("tipo_evento", linha);
                evento.NumeroPessoas = uint.Parse(ExtrairValorDoCampo("quantidade_pessoas", linha));
                
                eventos.Add(evento);
            }
            return eventos;
        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var todosEventos = ObterTodos();
            List<Evento> eventosCliente = new List<Evento>();

            foreach (var evento in todosEventos)
            {
                if (evento.Cliente.Email.Equals(emailCliente))
                {
                    eventosCliente.Add(evento);
                }
            }
            return eventosCliente;
        }
        
    }
}