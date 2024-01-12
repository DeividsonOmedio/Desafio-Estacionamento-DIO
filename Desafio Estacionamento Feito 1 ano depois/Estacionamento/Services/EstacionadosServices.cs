using Estacionamento.Models;
using Estacionamento.Models.Valores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class EstacionadosServices
    {
        List<Estacionados> listaEstacionados = new List<Estacionados>();

        public EstacionadosServices()
        {
            InserirEstacionadosIniciais();
        }
        public void EstacionarVeiculo(Veiculo veiculosId, Motorista motoristaId, DateTime dataEntrada, EnumTipoCobranca tipoCobranca, decimal desconto)
            {
                Estacionados estacionado = new Estacionados();
                estacionado.VeiculosId = veiculosId;
                estacionado.MotoristaId = motoristaId;
                estacionado.DataEntrada = dataEntrada;
                estacionado.TipoCobranca = tipoCobranca;
                estacionado.Desconto = desconto;
                listaEstacionados.Add(estacionado);
                Console.WriteLine($"Veiculo placa {veiculosId.Placa} adicionado com sucesso");
                
            }

            public void ListarEstacionados()
            {
                Console.WriteLine("Veiculos Estacionados:");
                foreach (var estacionado in listaEstacionados)
                {
                    Console.WriteLine($"Placa: {estacionado.VeiculosId.Placa}, Data de Entrada: {estacionado.DataEntrada}, Tipo de Cobrança: {estacionado.TipoCobranca}, Desconto: {estacionado.Desconto}");

                }
            }

            public void RemoverVeiculoEstacionado(string placa)
            {

                try
                {
                    var veiculo = listaEstacionados.FirstOrDefault(estacionado => estacionado.VeiculosId.Placa == placa);
                    if (veiculo == null)
                    {
                        Console.WriteLine("Veiculo não encontrado");
                    }
                    else
                    {
                    if (veiculo.TipoCobranca == EnumTipoCobranca.Hora)
                    {
                        Console.Write("Digite o tempo total que o veiculo ficou etacionado: ");
                        int horas = Convert.ToInt32(Console.ReadLine());
                        decimal precoPorHora = 0;
                        decimal precoInicial = 0;
                        if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.moto)
                        {
                            (decimal, decimal) precos = ValoresMoto();
                            precoInicial = precos.Item1;
                            precoPorHora = precos.Item2;
                        }
                        else if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.carro)
                        {
                            (decimal, decimal) precos = ValoresCarro();
                            precoInicial = precos.Item1;
                            precoPorHora = precos.Item2;
                        }
                        else if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.caminhonete)
                        {
                            (decimal, decimal) precos = ValoresCaminhonete();
                            precoInicial = precos.Item1;
                            precoPorHora = precos.Item2;
                        }
                        decimal valorTotal = horas * precoPorHora + precoInicial - veiculo.Desconto;
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("C1")}");
                        listaEstacionados.RemoveAll(estacionado => estacionado.VeiculosId.Placa == placa);
                        Console.WriteLine($"Veiculo placa {placa} removido com sucesso");
                        
                    }
                    else if (veiculo.TipoCobranca == EnumTipoCobranca.Diaria)
                    {
                        Console.Write("Digite quantos dias que o veiculo ficou etacionado: ");
                        int dias = Convert.ToInt32(Console.ReadLine());
                        decimal precoPorDia = 0;
                        decimal precoInicial = 0;
                        if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.moto)
                        {
                            (decimal, decimal) precos = ValoresMotoDia();
                            precoInicial = precos.Item1;
                            precoPorDia = precos.Item2;
                        }
                        else if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.carro)
                        {
                            (decimal, decimal) precos = ValoresCarroDia();
                            precoInicial = precos.Item1;
                            precoPorDia = precos.Item2;
                        }
                        else if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.caminhonete)
                        {
                            (decimal, decimal) precos = ValoresCaminhoneteDia();
                            precoInicial = precos.Item1;
                            precoPorDia = precos.Item2;
                        }
                        decimal valorTotal = dias * precoPorDia + precoInicial - veiculo.Desconto;
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("C1")}");
                        listaEstacionados.RemoveAll(estacionado => estacionado.VeiculosId.Placa == placa);
                        Console.WriteLine($"Veiculo placa {placa} removido com sucesso");
                        
                    }
                    else if (veiculo.TipoCobranca == EnumTipoCobranca.Mensal)
                    {
                        Console.Write("Digite quantos meses que o veiculo ficou etacionado: ");
                        int meses = Convert.ToInt32(Console.ReadLine());
                        decimal precoPorMes = 0;
                        decimal precoInicial = 0;
                        if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.moto)
                        {
                            (decimal, decimal) precos = ValoresMotoDia();
                            precoInicial = precos.Item1;
                            precoPorMes = precos.Item2;
                        }
                        else if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.carro)
                        {
                            (decimal, decimal) precos = ValoresCarroDia();
                            precoInicial = precos.Item1;
                            precoPorMes = precos.Item2;
                        }
                        else if (veiculo.VeiculosId.CategoriaVeiculo == EnumTipoVeiculo.caminhonete)
                        {
                            (decimal, decimal) precos = ValoresCaminhoneteDia();
                            precoInicial = precos.Item1;
                            precoPorMes = precos.Item2;
                        }
                        decimal valorTotal = meses * precoPorMes + precoInicial - veiculo.Desconto;
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("C1")}");
                        listaEstacionados.RemoveAll(estacionado => estacionado.VeiculosId.Placa == placa);
                        Console.WriteLine($"Veiculo placa {placa} removido com sucesso");
                        
                    }
                }
                }
                catch
                {
                    Console.WriteLine("Erro ao remover veiculo");
                }
            }
            public (decimal, decimal) ValoresMoto()
            {
                ValoresMoto moto = new ValoresMoto();
                return (moto.ValorInicial, moto.ValorHora);
            }
            public (decimal, decimal) ValoresCarro()
            {
                ValoresCarro carro = new ValoresCarro();
                return (carro.ValorInicial, carro.ValorHora);
            }
            public (decimal, decimal) ValoresCaminhonete()
            {
                ValoresCaminhonete caminhonete = new ValoresCaminhonete();
                return (caminhonete.ValorInicial, caminhonete.ValorHora);
            }
        public (decimal, decimal) ValoresMotoDia()
        {
            ValoresMoto moto = new ValoresMoto();
            return (moto.ValorInicial, moto.ValorDiaria);
        }
        public (decimal, decimal) ValoresCarroDia()
        {
            ValoresCarro carro = new ValoresCarro();
            return (carro.ValorInicial, carro.ValorDiaria);
        }
        public (decimal, decimal) ValoresCaminhoneteDia()
        {
            ValoresCaminhonete caminhonete = new ValoresCaminhonete();
            return (caminhonete.ValorInicial, caminhonete.ValorDiaria);
        }
        public (decimal, decimal) ValoresMotoMensal()
        {
            ValoresMoto moto = new ValoresMoto();
            return (moto.ValorInicial, moto.ValorMensal);
        }
        public (decimal, decimal) ValoresCarroMensal()
        {
            ValoresCarro carro = new ValoresCarro();
            return (carro.ValorInicial, carro.ValorMensal);
        }
        public (decimal, decimal) ValoresCaminhoneteMensal()
        {
            ValoresCaminhonete caminhonete = new ValoresCaminhonete();
            return (caminhonete.ValorInicial, caminhonete.ValorMensal);
        }

        public void InserirEstacionadosIniciais()
        {
            VeiculoServices novoV = new VeiculoServices();

            var veiculo = novoV.BuscarVeiculoPelaPlaca("guz-010");
            Motorista novoMotorista = new Motorista();
            novoMotorista.Id = 1;
            novoMotorista.Nome = "deivid";
            novoMotorista.Cpf = "423248574036";
            novoMotorista.DataNascimento = "21/12/2058";
            novoMotorista.Telefone = "3189087504";

            Veiculo novoVeiculo = new Veiculo();
            novoVeiculo.MotoristaId = novoMotorista;
            novoVeiculo.CategoriaVeiculo = EnumTipoVeiculo.carro;
            novoVeiculo.Placa = "gup-010";
            novoVeiculo.Cor = "roxo";

            Estacionados estacionado = new Estacionados();
            estacionado.VeiculosId = novoVeiculo;
            estacionado.MotoristaId = novoMotorista;
            estacionado.DataEntrada = DateTime.Now;
            estacionado.TipoCobranca = EnumTipoCobranca.Diaria;
            estacionado.Desconto = 0;
            listaEstacionados.Add(estacionado);
        }

    }

}

