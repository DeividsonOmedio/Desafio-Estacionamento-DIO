using Estacionamento.EstacionamentosServices;
using Estacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class LoginEstacionamento
    {
        public static void Login()
        {
            Console.Clear();
            
            FuncionarioService novoFuncionario = new FuncionarioService();
            novoFuncionario.ListarFuncionarios();
           



            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("\n\t                      Seja bem vindo ao sistema de estacionamento!                      \t\t\t");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Funcionarios buscado = null;
            do
            {
                Console.Write("\n Nome: ");
                string nomeDigitado = Console.ReadLine();
                buscado = novoFuncionario.BuscaruncionarioPeloNome(nomeDigitado);

                if (buscado == null)
                {
                    Console.WriteLine("Funcionário não encontrado");
                }

            } while (buscado == null);

            Console.Write("\n Senha: ");
            Console.ForegroundColor = ConsoleColor.Black;
            string senhaDigitado = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            while (senhaDigitado != buscado.Senha)
            {
                if (senhaDigitado != buscado.Senha)
                {
                    Console.WriteLine("Senha incorreta!");
                }
                Console.Write("\n Senha: ");
                Console.ForegroundColor = ConsoleColor.Black;
                senhaDigitado = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine($"Nome: {buscado.Nome}, Senha: {buscado.Senha}, Funcao: {buscado.Funcao}");

            AdministradorService Administrador = new AdministradorService();
            OperadorService operador = new OperadorService();

            if (buscado.Funcao == "admin")
                Administrador.Menu();
            else if (buscado.Funcao == "atendente")
                operador.Menu();
        }
    }
}
