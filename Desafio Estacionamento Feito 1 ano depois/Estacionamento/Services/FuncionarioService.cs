using Estacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class FuncionarioService
    {
        private List<Funcionarios> ListaFuncionarios { get; set; }

        int id = 1;

        public FuncionarioService()
        {
            ListaFuncionarios = new List<Funcionarios>();
            AdicionarFuncionariosInicio();

        }
        public void AdicionarFuncionariosInicio()
        {
            AddFuncionario("deividson", "admin123", "admin");
            AddFuncionario("gaby", "admin123", "atendente");
        }

        public void AddFuncionario(string nome, string senha, string funcao)
        {
            Funcionarios novoFuncionario = new Funcionarios();
            novoFuncionario.Id = id++;
            novoFuncionario.Nome = nome;
            novoFuncionario.Senha = senha;
            novoFuncionario.Funcao = funcao;

            ListaFuncionarios.Add(novoFuncionario);
        }

        public void ListarFuncionarios()
        {
            foreach (var funcionario in ListaFuncionarios)
            
            {
                Console.WriteLine($"ID: {funcionario.Id}, Nome: {funcionario.Nome}, Senha: {funcionario.Senha}, Funcao: {funcionario.Funcao}");
            }
        }

        public Funcionarios BuscaruncionarioPeloNome(string nome)
        {
            
            Funcionarios funcionario = ListaFuncionarios.FirstOrDefault(x => x.Nome == nome);
            return funcionario; 
        }
        public void RemoverFuncionario(string funcionario)
        {
            ListaFuncionarios.RemoveAll(Funcionario => Funcionario.Nome == funcionario);
            Console.WriteLine($"{funcionario} removido com sucesso!");
        }
    }
}
