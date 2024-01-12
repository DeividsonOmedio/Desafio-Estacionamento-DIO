using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models.Valores
{
    public class ValoresCaminhonete : Valores
    {
        public decimal ValorInicial { get; set; } = 5;
        public decimal ValorHora { get; set; } = 12;
        public decimal ValorDiaria { get; set; } = 40;
        public decimal ValorMensal { get; set; } = 220;
    }
}
