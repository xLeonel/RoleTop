using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Enums;
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
            var quantidadeClientes = File.ReadAllLines(PATH).Length;
            cliente.Id = (ulong) ++quantidadeClientes;
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
                    cliente.Id = ulong.Parse(ExtrairValorDoCampo("id", item));
                    cliente.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    cliente.StatusCliente = uint.Parse((ExtrairValorDoCampo("status_cliente", item)));
                    cliente.Nome = ExtrairValorDoCampo("nome", item);
                    cliente.Senha = ExtrairValorDoCampo("senha", item);
                    cliente.Email = ExtrairValorDoCampo("email", item);
                    cliente.Celular = ExtrairValorDoCampo("celular", item);
                    cliente.Cpf = ExtrairValorDoCampo("cpf", item);
                    cliente.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", item));
                    cliente.URLFotoPerfil = ExtrairValorDoCampo("url_foto", item);

                    return cliente;
                }
            }
            return null;
        }

        public List<Cliente> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Cliente> clientes = new List<Cliente>();
            foreach (var item in linhas)
            {

                Cliente cliente = new Cliente();
                cliente.Id = ulong.Parse(ExtrairValorDoCampo("id", item));
                cliente.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                cliente.StatusCliente = uint.Parse((ExtrairValorDoCampo("status_cliente", item)));
                cliente.Nome = ExtrairValorDoCampo("nome", item);
                cliente.Senha = ExtrairValorDoCampo("senha", item);
                cliente.Email = ExtrairValorDoCampo("email", item);
                cliente.Celular = ExtrairValorDoCampo("celular", item);
                cliente.Cpf = ExtrairValorDoCampo("cpf", item);
                cliente.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", item));
                cliente.URLFotoPerfil = ExtrairValorDoCampo("url_foto", item);

                clientes.Add(cliente);

            }
            return clientes;
        }

        public bool Atualizar(Cliente cliente)
        {
            var clienteTotais = File.ReadAllLines(PATH);
            var clienteCSV = PrepararRegistroCSV(cliente);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < clienteTotais.Length; i++)
            {
                var email = ExtrairValorDoCampo("email", clienteTotais[i]);
                if (cliente.Email.Equals(email))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                clienteTotais[linhaPedido] = clienteCSV;
                File.WriteAllLines(PATH, clienteTotais);
            }

            return resultado;
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

        public List<Cliente> ObterClientePor(uint status)
        {
            List<Cliente> clientes = new List<Cliente>();
            var todosCliente = ObterTodos();

            foreach (var cliente in todosCliente)
            {
                if (cliente.TipoUsuario.Equals(0))
                {
                    if (cliente.StatusCliente.Equals(status))
                    {
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }


        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"id={cliente.Id};tipo_usuario={cliente.TipoUsuario};status_cliente={cliente.StatusCliente};nome={cliente.Nome};senha={cliente.Senha};email={cliente.Email};celular={cliente.Celular};cpf={cliente.Cpf};data_nascimento={cliente.DataNascimento.ToShortDateString()};url_foto={cliente.URLFotoPerfil}";
        }
    }
}