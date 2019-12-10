using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class PerguntaFaqRepository
    {
        private const string PATH = "Database/PerguntaFaq.csv";

        public List<Pergunta> ObterTodos()
        {
            List<Pergunta> perguntasRespostas = new List<Pergunta>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Pergunta pergunta = new Pergunta();
                string[] dados = linha.Split(";");
                pergunta.Question = dados[0];
                pergunta.Awnser = dados[1];
                perguntasRespostas.Add(pergunta);
            }

            return perguntasRespostas;
        }
    }
}