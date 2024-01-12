using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Estacionados: Generics
    {

        public Veiculo VeiculosId { get; set; }
        public Motorista MotoristaId { get; set; }
        public DateTime DataEntrada { get; set; }
        public EnumTipoCobranca TipoCobranca { get; set; }
        public decimal Desconto { get; set; }

    }
}
