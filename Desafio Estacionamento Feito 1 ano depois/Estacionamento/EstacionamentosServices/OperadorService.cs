using Estacionamento.Models;
using Estacionamento.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Estacionamento.EstacionamentosServices
{
    public class OperadorService
    {
        bool exibirMenu = true;
        int menuPrincipal;
        EstacionadosServices estacionado = new EstacionadosServices();


        public void Menu()
        {
            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar Veículo");
                Console.WriteLine("2 - Remover Veículo");
                Console.WriteLine("3 - Listar Veículos Estacionados");
                Console.WriteLine("4 - Listar Motoristas Cadastrados");
                Console.WriteLine("5 - Listar veículos Cadastrados");
                Console.WriteLine("6 - Logout");
                Console.WriteLine("7 - Encerrar");
                menuPrincipal = Convert.ToInt32(Console.ReadLine());

                switch (menuPrincipal)
                {
                    case 1:
                        var motorista = AcharMotorista();
                        var veiculo = AcharVeiculo(motorista);
                        DateTime dataAtual = DateTime.Now;
                        Console.WriteLine("Selecione o tipo de cobrança: \n 1 - Hora \n 2 - Diaria \n 3 - Mensal");
                        EnumTipoCobranca cobranca = (EnumTipoCobranca)Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Desconto? digite 0 ou o valor do desconto");
                        decimal desconto = Convert.ToDecimal(Console.ReadLine());
                        estacionado.EstacionarVeiculo(veiculo, motorista, dataAtual, cobranca, desconto);
                        break;

                    case 2:
                        Console.WriteLine("Digite a placa do veiculo");
                        string placaRemover = Console.ReadLine();
                        estacionado.RemoverVeiculoEstacionado(placaRemover);
                        break;

                    case 3:
                        estacionado.ListarEstacionados();
                        break;
                    case 4:
                        MotoristaService motoristaService = new MotoristaService();
                        motoristaService.ListarMotoristas();
                        break;
                    case 5:
                        VeiculoServices veiculoServices = new VeiculoServices();
                        veiculoServices.ListarVeiculos();
                        break;
                    case 6:
                        LoginEstacionamento.Login();
                        break;
                    case 7:
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("\nPressione uma tecla para continuar");
                Console.ReadLine();
            }
        }
        public Motorista AcharMotorista()
        {
            MotoristaService motoristaService = new MotoristaService();
            Console.WriteLine("Digite o nome do motorista ou 9 para Listar motoristas ativos ou 0 para cadastrar um novo motorista");
            string nome = Console.ReadLine();
            if(nome == "9")
            {
                motoristaService.ListarMotoristas();
                Console.WriteLine("Digite o nome do motorista");
                nome =  Console.ReadLine();
                return motoristaService.BuscarMotoristaPeloNome(nome);
            }
            else if(nome == "0")
            {
                Console.Write("Digite o nome do motorista: ");
                nome = Console.ReadLine();
                Console.Write("Digite o cpf do motorista: ");
                string cpf = Console.ReadLine();
                Console.Write("Digite a data de nascimento do motorista: ");
                string data = Console.ReadLine();
                Console.Write("Digite o telefone do motorista: ");
                string telefone = Console.ReadLine();
                string retorno = motoristaService.AddMotorista(nome, cpf, data, telefone);
                if (retorno == "sucesso")
                    return motoristaService.BuscarMotoristaPeloNome(nome);
            }
            return motoristaService.BuscarMotoristaPeloNome(nome);
        }
        public Veiculo AcharVeiculo(Motorista motorista)
        {
            Veiculo buscado = new Veiculo();
            VeiculoServices buscarVeiculo = new VeiculoServices();
            Console.WriteLine("Digite a placa do veiculo:");
            string placa = Console.ReadLine();
            var veiculoBuscado = buscarVeiculo.BuscarVeiculoPelaPlaca(placa);

            if (veiculoBuscado != null)
            {
                return veiculoBuscado;
            }
                
                Console.WriteLine("Digite a cor do veiculo");
                string novaCor = Console.ReadLine();
                Console.WriteLine("Escolha uma opção: \n 1 - Moto \n 2 - Carro \n 3 - Caminhonete");
                EnumTipoVeiculo novaCategoriaVeiculo = (EnumTipoVeiculo)Convert.ToInt32(Console.ReadLine());
                string retorno = buscarVeiculo.AdcionarVeiculo(motorista, novaCategoriaVeiculo, placa, novaCor);
                if (retorno == "sucesso")
                   veiculoBuscado = buscarVeiculo.BuscarVeiculoPelaPlaca(placa);

            return veiculoBuscado;
               
                
            
            
        }
   
    }
}
