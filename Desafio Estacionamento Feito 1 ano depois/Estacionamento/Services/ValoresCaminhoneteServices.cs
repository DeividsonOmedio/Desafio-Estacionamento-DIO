using Estacionamento.Models.Valores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class ValoresCaminhoneteServices
    {
        public ValoresCaminhoneteServices()
        {
            Valores = new ValoresCaminhonete();
        }
        public ValoresCaminhonete Valores { get; set; }
        public void AdicionarValoes(decimal valorInicial, decimal valorHora, decimal valorDiaria, decimal valorMensal)
        {
            Valores.ValorInicial = valorInicial;
            Valores.ValorHora = valorHora;
            Valores.ValorDiaria = valorDiaria;
            Valores.ValorMensal = valorMensal;

        }

        public void ListarValores()
        {
            Console.Write("Valores Para Caminhonetes: ");

            Console.WriteLine($"Valor Inicial: {Valores.ValorInicial.ToString("C")}, Valor da Hora: {Valores.ValorHora.ToString("C")}, Valor da Diaria: {Valores.ValorDiaria.ToString("C")}, Valor Mensal: {Valores.ValorMensal.ToString("C")}");

        }
    }
}
