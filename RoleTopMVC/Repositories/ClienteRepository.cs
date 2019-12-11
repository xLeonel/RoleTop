using System;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente cliente = new Cliente();
                    cliente.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    cliente.Nome = ExtrairValorDoCampo("nome", item);
                    cliente.Senha = ExtrairValorDoCampo("senha", item);
                    cliente.Email = ExtrairValorDoCampo("email", item);
                    cliente.Celular = ExtrairValorDoCampo("celular", item);
                    cliente.Cpf = uint.Parse(ExtrairValorDoCampo("cpf", item));
                    cliente.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", item));
                    cliente.URLFotoPerfil = ExtrairValorDoCampo("url_foto", item);

                    return cliente;
                }
            }
            return null;
        }

        public bool AtualizarSenha(string email, string senhaNova)
        {
            var cliente = ObterPor(email);
            cliente.Senha = senhaNova;
            var clienteCSV = PrepararRegistroCSV(cliente);
            var linhas = File.ReadAllLines(PATH);
            var linhaUsuario = -1;
            var resultado = false;

            for (int i = 0; i < linhas.Length; i++)
            {
                if (cliente.Email == ExtrairValorDoCampo("email", linhas[i]))
                {
                    linhaUsuario = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                linhas[linhaUsuario] = clienteCSV;
                File.WriteAllLines(PATH, linhas);
            }

             return resultado;
            // eventoTotais[linhaPedido] = eventoCSV;
            // File.WriteAllLines(PATH, eventoTotais);
        }

         public bool AtualizarFoto(string email, string urlFoto)
        {
            var cliente = ObterPor(email);
            cliente.URLFotoPerfil = urlFoto;
            var clienteCSV = PrepararRegistroCSV(cliente);
            var linhas = File.ReadAllLines(PATH);
            var linhaUsuario = -1;
            var resultado = false;

            for (int i = 0; i < linhas.Length; i++)
            {
                if (cliente.Email == ExtrairValorDoCampo("email", linhas[i]))
                {
                    linhaUsuario = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                linhas[linhaUsuario] = clienteCSV;
                File.WriteAllLines(PATH, linhas);
            }

             return resultado;
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};senha={cliente.Senha};email={cliente.Email};celular={cliente.Celular};cpf={cliente.Cpf};data_nascimento={cliente.DataNascimento.ToShortDateString()};url_foto={cliente.URLFotoPerfil}";
        }
    }
}