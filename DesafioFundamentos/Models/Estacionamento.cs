namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        
        string placaRemover;
        string placaAdd;
        int categoria;
        
        private decimal precoInicial = 0;
        private decimal precoPorHoraMotos = 0;
        private decimal precoPorHoraLeves = 0;
        private decimal precoPorHoraCaminhonetes = 0;

        private List<string> leves = new List<string>();
        private List<string> caminhonetes = new List<string>();

        private List<string> motos = new List<string>();


        public Estacionamento(decimal precoInicial, decimal precoPorHoraLeves, decimal precoPorHoraMotos, decimal precoPorHoraCaminhonetes)
        {
            this.precoInicial = precoInicial;
            this.precoPorHoraLeves = precoPorHoraLeves;
            this.precoPorHoraMotos = precoPorHoraMotos;
            this.precoPorHoraCaminhonetes = precoPorHoraCaminhonetes;
        }

        public void IniciarSistema()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            
            Console.WriteLine("\n\t\t\t                      Seja bem vindo ao sistema de estacionamento!");
                  
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            
            Console.WriteLine("\nDigite o preço inicial:");

            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora para Motos:");
            precoPorHoraMotos = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Agora digite o preço por hora para Carros leves:");
            precoPorHoraLeves = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Agora digite o preço por hora para Caminhonetes:");
            precoPorHoraCaminhonetes = Convert.ToDecimal(Console.ReadLine());
        }

        public void AdicionarVeiculo()
        {   
           
            Console.WriteLine("Escolha uma categoria:\n"+
            "1 - moto \n2 - Carros leves\n3 - Caminhonetes");
            categoria =  Convert.ToInt32(Console.ReadLine());
           
         
            switch(categoria)
            {
                case 1:
                    Console.WriteLine("Digite a placa do veículo para estacionar:");
                    placaAdd = Console.ReadLine();
                    motos.Add(placaAdd);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Moto adicionada ao sistema");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("\n");
                    break;
                case 2:
                    Console.WriteLine("Digite a placa do veículo para estacionar:");
                    placaAdd = Console.ReadLine();
                    leves.Add(placaAdd);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Carro adicionado ao sistema");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("\n");
                    break;
                case 3:
                    Console.WriteLine("Digite a placa do veículo para estacionar:");
                    placaAdd = Console.ReadLine();
                    caminhonetes.Add(placaAdd);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Caminhonete adicionada ao sistema");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("\n");
                    break;                
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            placaRemover = Console.ReadLine();
            
            if (motos.Any(x => x.ToUpper() == placaRemover.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = horas * precoPorHoraMotos + precoInicial; 

                leves.Remove(placaRemover);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal.ToString("C1")}");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (leves.Any(x => x.ToUpper() == placaRemover.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = horas * precoPorHoraLeves + precoInicial; 

                leves.Remove(placaRemover);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal.ToString("C1")}");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (caminhonetes.Any(x => x.ToUpper() == placaRemover.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = horas * precoPorHoraCaminhonetes + precoInicial; 

                leves.Remove(placaRemover);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal.ToString("C1")}");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (motos.Any())
            {
                Console.WriteLine("\nMotos estacionadas:\n");
                
                foreach(string p in motos)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(p);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
               
            }
             else
            {
                Console.WriteLine("\nNão há motos estacionadas.");
            }
            if(leves.Any())
            {
                Console.WriteLine("\nCarros leves estacionado:\n");
                 foreach(string p in leves)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(p);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
             else
            {
                Console.WriteLine("\nNão há carros leves estacionados.");
            }
            if(caminhonetes.Any())
            {
                Console.WriteLine("\nCaminhonetes estacionadas:\n");
                 foreach(string p in caminhonetes)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(p);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            else
            {
                Console.WriteLine("\nNão há caminhonetes estacionadas.");
            }
        }
    }
}
