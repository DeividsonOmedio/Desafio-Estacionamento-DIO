using Estacionamento.Models;
using Estacionamento.Models.Valores;
using Estacionamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.EstacionamentosServices
{
    public class AdministradorService
    {
        bool exibirMenu = true;
        int menuPrincipal;
        ValoresMotosServices moto = new ValoresMotosServices();
        ValoresCarrosServices carro = new ValoresCarrosServices();
        ValoresCaminhoneteServices caminhonete = new ValoresCaminhoneteServices();
        FuncionarioService funcionario = new FuncionarioService();
        public void Menu()
        {
            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Listar Valores");
                Console.WriteLine("2 - Alterar Valores");
                Console.WriteLine("3 - Listar Funcionários");
                Console.WriteLine("4 - Adicionar Novo Funcionário");
                Console.WriteLine("5 - Remover Funcionário");
                Console.WriteLine("6 - Logout");
                Console.WriteLine("7 - Encerrar");
                menuPrincipal = Convert.ToInt32(Console.ReadLine());
                
                switch (menuPrincipal)
                {
                    case 1:
                        moto.ListarValores();
                        carro.ListarValores();
                        caminhonete.ListarValores();
                        Console.WriteLine("Pressione Enter para continuar...");
                        Console.ReadLine();

                        break;

                    case 2:
                        try
                        {
                            string categoria = "Motos";
                            (decimal, decimal, decimal, decimal) novosValoresMotos = ReceberValores(categoria);
                            moto.AdicionarValoes(novosValoresMotos.Item1 , novosValoresMotos.Item2, novosValoresMotos.Item3, novosValoresMotos.Item4);
                            Console.WriteLine("Pressione Enter para continuar...");
                            Console.ReadLine();

                            categoria = "Carros";
                            (decimal, decimal, decimal, decimal) novosValoresCarros = ReceberValores(categoria);
                            carro.AdicionarValoes(novosValoresCarros.Item1, novosValoresCarros.Item2, novosValoresCarros.Item3, novosValoresCarros.Item4);
                            Console.WriteLine("Pressione Enter para continuar...");
                            Console.ReadLine();

                            categoria = "Caminhonetes";
                            (decimal, decimal, decimal, decimal) novosValoresCaminhonetes = ReceberValores(categoria);
                            caminhonete.AdicionarValoes(novosValoresCaminhonetes.Item1, novosValoresCaminhonetes.Item2, novosValoresCaminhonetes.Item3, novosValoresCaminhonetes.Item4);
                            Console.WriteLine("Pressione Enter para continuar...");
                            Console.ReadLine();
                        }
                        catch
                        {
                            Console.WriteLine("Erro ao Atualizar Valores");
                        }
                        
                        break;

                    case 3:
                        funcionario.ListarFuncionarios();
                        Console.WriteLine("Pressione Enter para continuar...");
                        Console.ReadLine();
                        break;

                    case 4:
                        try
                        {
                        (string, string, string) novoFuncionario = ReceberNovoFuncionario();
                        funcionario.AddFuncionario(novoFuncionario.Item1, novoFuncionario.Item2, novoFuncionario.Item3);
                            Console.WriteLine("Pressione Enter para continuar...");
                            Console.ReadLine();
                        }
                        catch
                        {
                            Console.WriteLine("Erro ao Adicionar Novo Usuario");
                        }
                        break;

                    case 5:
                        try
                        {
                            Console.Write("Digite o nome do usuario a ser removido: ");
                            string nome = Console.ReadLine();
                            funcionario.RemoverFuncionario(nome);
                            Console.WriteLine("Pressione Enter para continuar...");
                            Console.ReadLine();
                        }
                        catch
                        {
                            Console.WriteLine("Erro ao Remover Usuario");
                        }
                        break;

                    case 6:
                        LoginEstacionamento.Login();
                        break;

                    case 7:
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Pressione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }

                static (decimal, decimal, decimal, decimal) ReceberValores(string categoria)
                {
                    try
                    {
                        Console.Clear();
                    Console.WriteLine($"Valores para {0}", categoria);
                    Console.Write("Digite o valor Inicial: ");
                    decimal valorInicial = decimal.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da Hora: ");
                    decimal valorHora = decimal.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da Diaria: ");
                    decimal valorDiaria = decimal.Parse(Console.ReadLine());
                    Console.Write("Digite o valor Mensal: ");
                    decimal valorMensal = decimal.Parse(Console.ReadLine());
                    return (valorInicial ,valorHora, valorDiaria, valorMensal);
                    }
                    catch
                    {
                        Console.WriteLine("Digite Valores Válidos");
                        return (0, 0, 0, 0);
                    }

                }

                static (string, string, string) ReceberNovoFuncionario()
                {
                    Console.Write("Digite o Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a Senha: ");
                    string senha = Console.ReadLine();
                    Console.Write("Digite a Função: ");
                    string funcao = Console.ReadLine();

                    return (nome, senha, funcao);
                }

                
            }
        }
       
        
    }
}
