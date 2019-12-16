using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class DepoimentoRepository : RepositoryBase
    {
        private const string PATH = "Database/Depoimento.csv";

         public DepoimentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

         public bool Inserir(Depoimento depoimento)
        {
            var linha = new string[] { PrepararRegistroCSV(depoimento) };
            File.AppendAllLines(PATH, linha);

            return true;            
        }

        private string PrepararRegistroCSV(Depoimento depoimento)
        {
            return $"nome={depoimento.Cliente.Nome};email={depoimento.Cliente.Email};url_foto={depoimento.Cliente.URLFotoPerfil};mensagem={depoimento.Mensagem}";
        }

        public List<Depoimento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Depoimento> depoimentos = new List<Depoimento>();

            foreach (var linha in linhas)
            {
                Depoimento depoimento = new Depoimento();
                
                depoimento.Cliente.Nome = ExtrairValorDoCampo("nome", linha);
                depoimento.Cliente.Email = ExtrairValorDoCampo("email", linha);
                depoimento.Cliente.URLFotoPerfil = ExtrairValorDoCampo("url_foto", linha);
                depoimento.Mensagem = ExtrairValorDoCampo("mensagem", linha);
    
                depoimentos.Add(depoimento);
            }
            return depoimentos;
        }

    }
}