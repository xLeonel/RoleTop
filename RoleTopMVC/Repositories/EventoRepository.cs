using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Enums;
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
            var quantidadeEvento = File.ReadAllLines(PATH).Length;
            evento.Id = (ulong) ++quantidadeEvento;
            var linha = new string[] { PrepararRegistroCSV(evento) };
            File.AppendAllLines(PATH, linha);

            return true;         
        }

        private string PrepararRegistroCSV(Evento evento)
        {
            return $"id={evento.Id};evento_nome={evento.NomeEvento};cliente_nome={evento.Cliente.Nome};cliente_email={evento.Cliente.Email};cliente_cpf={evento.Cliente.Cpf};cliente_celular={evento.Cliente.Celular};dia_evento={evento.DiaEvento.ToShortDateString()};tipo_evento={evento.TipoEvento};quantidade_pessoas={evento.NumeroPessoas};status_evento={evento.Status};pacote_evento={evento.PacoteEvento};privacidade_evento={evento.Privacidade};url_foto={evento.URLFotoPerfil}";
        }

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> eventos = new List<Evento>();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                
                evento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.NomeEvento = ExtrairValorDoCampo("evento_nome", linha);
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                evento.Cliente.Cpf = ExtrairValorDoCampo("cliente_cpf", linha);
                evento.Cliente.Celular = ExtrairValorDoCampo("cliente_celular", linha);
                evento.DiaEvento = DateTime.Parse(ExtrairValorDoCampo("dia_evento", linha));
                evento.TipoEvento = ExtrairValorDoCampo("tipo_evento", linha);
                evento.NumeroPessoas = uint.Parse(ExtrairValorDoCampo("quantidade_pessoas", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status_evento", linha));
                evento.PacoteEvento = ExtrairValorDoCampo("pacote_evento", linha);
                evento.Privacidade = uint.Parse(ExtrairValorDoCampo("privacidade_evento", linha));
                evento.URLFotoPerfil = ExtrairValorDoCampo("url_foto", linha);
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

        public Evento ObterPor(ulong id)
        {
            var eventoTotais =  ObterTodos();

            foreach (var evento in eventoTotais)
            {
                if (id.Equals(evento.Id))
                {
                    return evento;
                }
            }
            return null;
        }

        public List<Evento> ObterEventoPor(uint statusEvento)
        {
            List<Evento> eventos = new List<Evento>();
            var todosEvento = ObterTodos();

            foreach (var item in todosEvento)
            {
                if (item.Status.Equals(statusEvento))
                {
                    eventos.Add(item);
                }
            }
            return eventos;
        }

        public List<Evento> ObterPrivacidade(uint Privacidade)
        {
            List<Evento> eventos = new List<Evento>();
            var todosEvento = ObterTodos();

            foreach (var item in todosEvento)
            {
                if (item.Privacidade.Equals(Privacidade))
                {
                    eventos.Add(item);
                }
            }
            return eventos;
        }

        public bool Atualizar(Evento evento)
        {
            var eventoTotais = File.ReadAllLines(PATH);
            var eventoCSV =  PrepararRegistroCSV(evento);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < eventoTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id",eventoTotais[i]));
                if (evento.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }
            
            if(resultado)
            {
                eventoTotais[linhaPedido] = eventoCSV;
                File.WriteAllLines(PATH, eventoTotais);
            }

            return resultado;
        }

        public bool AtualizarFoto(ulong id, string urlFoto)
        {
            var evento = ObterPor(id);
            evento.URLFotoPerfil = urlFoto;
            var eventoCSV = PrepararRegistroCSV(evento);
            var linhas = File.ReadAllLines(PATH);
            var linhaUsuario = -1;
            var resultado = false;

            for (int i = 0; i < linhas.Length; i++)
            {
                if (evento.Id == ulong.Parse(ExtrairValorDoCampo("id", linhas[i])))
                {
                    linhaUsuario = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                linhas[linhaUsuario] = eventoCSV;
                File.WriteAllLines(PATH, linhas);
            }

             return resultado;
        }
        
    }
}