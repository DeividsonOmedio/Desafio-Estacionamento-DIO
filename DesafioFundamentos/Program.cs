using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHoraLeves = 0;
decimal precoPorHoraMotos = 0;
decimal precoPorHoraCaminhonetes = 0;


Estacionamento es = new Estacionamento(precoInicial, precoPorHoraLeves, precoPorHoraMotos, precoPorHoraCaminhonetes);

string opcao = string.Empty;
bool exibirMenu = true;
int menuPrincipal;

es.IniciarSistema();

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    menuPrincipal = Convert.ToInt32(Console.ReadLine());

    switch (menuPrincipal)
    {
        case 1:
            es.AdicionarVeiculo();
            break;

        case 2:
            es.RemoverVeiculo();
            break;

        case 3:
            es.ListarVeiculos();
            break;

        case 4:
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
