using Estacionamento.Models.Valores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public interface ValoresInterface
    {
        public void AdicionarValoes(decimal valorInicial, decimal valorHora, decimal valorDiaria, decimal valorMensal);
        public void ListarValores();

    }
}
