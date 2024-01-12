using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models.Valores
{
    public interface Valores
    {
        public decimal ValorInicial { get; set; }
        public decimal ValorHora { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorMensal { get; set; }
    }
}
