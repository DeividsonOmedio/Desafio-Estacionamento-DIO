
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Veiculo : Generics
    {
        public Motorista MotoristaId { get; set; }
        public EnumTipoVeiculo CategoriaVeiculo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
    }
}
