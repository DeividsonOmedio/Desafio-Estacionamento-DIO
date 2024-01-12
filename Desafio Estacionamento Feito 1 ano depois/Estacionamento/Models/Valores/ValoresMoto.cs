using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models.Valores
{
    public class ValoresMoto : Valores
    {
        public decimal ValorInicial { get; set; } = 5;
        public decimal ValorHora { get; set; } = 6;
        public decimal ValorDiaria { get; set; } = 18;
        public decimal ValorMensal { get; set; } = 50;
    }
}
