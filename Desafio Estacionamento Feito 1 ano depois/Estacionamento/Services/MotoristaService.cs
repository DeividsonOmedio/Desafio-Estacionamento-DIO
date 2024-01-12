using Estacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class MotoristaService
    {
        private List<Motorista> ListaMotorista { get; set; }

        int id = 1;

        public MotoristaService() 
        {
            ListaMotorista = new List<Motorista>();
            InserirMotoristasIiciais();
        }
       

        public string AddMotorista(string nome, string cpf, string dataNascimento, string telefone)
        { 
            Motorista novoMotorista = new Motorista();
            novoMotorista.Id = id++;
            novoMotorista.Nome = nome;
            novoMotorista.Cpf = cpf;
            novoMotorista.DataNascimento = dataNascimento;
            novoMotorista.Telefone = telefone;

            ListaMotorista.Add(novoMotorista);
            Console.WriteLine($"Motorista {nome} adicionado com sucesso!");
            return "sucesso";
        }

        public void ListarMotoristas()
        {
            foreach (var motorista in ListaMotorista)
            {
                Console.WriteLine($"ID: {motorista.Id}, Nome: {motorista.Nome}, CPF: {motorista.Cpf}, Data de Nascimento: {motorista.DataNascimento}, Telefone: {motorista.Telefone}");
            }
        }
        public Motorista BuscarMotoristaPeloNome(string nome)
        {
            return ListaMotorista.FirstOrDefault(motorista => motorista.Nome == nome);
        }
        public void InserirMotoristasIiciais()
        {
            Motorista novoMotorista = new Motorista();
            novoMotorista.Id = id++;
            novoMotorista.Nome = "deivid";
            novoMotorista.Cpf = "423248574036";
            novoMotorista.DataNascimento = "21/12/2058";
            novoMotorista.Telefone = "3189087504";
            ListaMotorista.Add(novoMotorista);

            Motorista novoMotorista2 = new Motorista();
            novoMotorista2.Id = id++;
            novoMotorista2.Nome = "gaby";
            novoMotorista2.Cpf = "423246536";
            novoMotorista2.DataNascimento = "21/12/2058";
            novoMotorista2.Telefone = "3189087504";
            ListaMotorista.Add(novoMotorista2);

            Motorista novoMotorista3 = new Motorista();
            novoMotorista3.Id = id++;
            novoMotorista3.Nome = "sofia";
            novoMotorista3.Cpf = "45534";
            novoMotorista3.DataNascimento = "21/12/2058";
            novoMotorista3.Telefone = "3189087504";
            ListaMotorista.Add(novoMotorista3);
        }
    }
}
