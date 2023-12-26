namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
             Console.WriteLine("Digite a placa do veículo para remover:");

            //Implementado
            string placa = Console.ReadLine(); 
           
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                //Implementado
                string horas = Console.ReadLine();
                decimal horasEmDecimal = decimal.Parse(horas);

                decimal valorTotal = precoInicial + precoPorHora * horasEmDecimal;
    
                veiculos.Remove(placa); 
             

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {   //Implementado
                Console.WriteLine("Os veículos estacionados são:");
                
                for( int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($" Posição Nº{contador + 1} - {veiculos[contador]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
