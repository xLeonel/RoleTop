using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class TipoEventoRepository
    {
        private const string PATH = "Database/TipoEvento.csv";

        public List<Evento> ObterTodos()
        {
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                string[] dados = linha.Split(";");
                evento.TipoEvento = dados[0];
                eventos.Add(evento);
            }

            return eventos;
        }
    }
}