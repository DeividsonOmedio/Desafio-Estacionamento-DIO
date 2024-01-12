using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models.Valores
{
    public class ValoresCarro : Valores
    {
        public decimal ValorInicial { get; set; } = 8;
        public decimal ValorHora { get; set; } = 7;
        public decimal ValorDiaria { get; set; } = 22;
        public decimal ValorMensal { get; set; } = 170;
    }
}
