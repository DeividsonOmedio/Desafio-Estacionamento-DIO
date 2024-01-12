
using Estacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class VeiculoServices
    {
        private List<Veiculo> ListaVeiculos { get; set; }

        public VeiculoServices()
        {
            ListaVeiculos = new List<Veiculo>();
            InserirVeiculoIniciais();
        }
     
        public string AdcionarVeiculo(Motorista motorista, EnumTipoVeiculo categoria, string placa, string cor)
        {
            try
            {
                Veiculo novoVeiculo = new Veiculo();
                novoVeiculo.MotoristaId = motorista;
                novoVeiculo.CategoriaVeiculo = categoria;
                novoVeiculo.Placa = placa;
                novoVeiculo.Cor = cor;
                ListaVeiculos.Add(novoVeiculo);
                Console.WriteLine($"Veiculo placa {placa} Cadastrado com suceso!");
                return "sucesso";
            }
            catch
            {
                Console.WriteLine("Erro ao adcionar Veiculo");
                return "falha";
            }
        }
        public void ListarVeiculos()
        {
            if (ListaVeiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos cadastrados.");
            }
            else
            {
                Console.WriteLine("Lista de Veículos:");
                foreach (var veiculo in ListaVeiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Placa}, Categoria: {veiculo.CategoriaVeiculo}, Cor: {veiculo.Cor}, Motorista: {veiculo.MotoristaId.Nome}");
                }
            }
        }
        public Veiculo BuscarVeiculoPelaPlaca(string placa)
        {
            return ListaVeiculos.FirstOrDefault(veiculo => veiculo.Placa == placa);
        }

        public void InserirVeiculoIniciais()
        {
            Motorista novoMotorista = new Motorista();
            novoMotorista.Id = 1;
            novoMotorista.Nome = "deivid";
            novoMotorista.Cpf = "423248574036";
            novoMotorista.DataNascimento = "21/12/2058";
            novoMotorista.Telefone = "3189087504";
            
            Veiculo novoVeiculo = new Veiculo();
            novoVeiculo.MotoristaId = novoMotorista;
            novoVeiculo.CategoriaVeiculo = EnumTipoVeiculo.carro;
            novoVeiculo.Placa = "gup-010";
            novoVeiculo.Cor = "roxo";
            ListaVeiculos.Add(novoVeiculo);


            Motorista novoMotorista2 = new Motorista();
            novoMotorista2.Id = 2;
            novoMotorista2.Nome = "gaby";
            novoMotorista2.Cpf = "423246536";
            novoMotorista2.DataNascimento = "21/12/2058";
            novoMotorista2.Telefone = "3189087504";

            Veiculo novoVeiculo2 = new Veiculo();
            novoVeiculo2.MotoristaId = novoMotorista2;
            novoVeiculo2.CategoriaVeiculo = EnumTipoVeiculo.caminhonete;
            novoVeiculo2.Placa = "gup-009";
            novoVeiculo2.Cor = "rosa";
            ListaVeiculos.Add(novoVeiculo2);


            Motorista novoMotorista3 = new Motorista();
            novoMotorista3.Id = 3;
            novoMotorista3.Nome = "sofia";
            novoMotorista3.Cpf = "45534";
            novoMotorista3.DataNascimento = "21/12/2058";
            novoMotorista3.Telefone = "3189087504";


            Veiculo novoVeiculo3 = new Veiculo();
            novoVeiculo3.MotoristaId = novoMotorista3;
            novoVeiculo3.CategoriaVeiculo = EnumTipoVeiculo.caminhonete;
            novoVeiculo3.Placa = "gup-123";
            novoVeiculo3.Cor = "preto";
            ListaVeiculos.Add(novoVeiculo3);
        }

    }
}
