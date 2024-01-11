using System.Diagnostics.Contracts;

namespace DesafioFundamentos.Models{
    public class Estacionamento{
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){
            
            Console.Write("Digite a placa do veículo para estacionar: ");
            string plaquinha = Console.ReadLine();
            veiculos.Add(plaquinha);
        }

        public void RemoverVeiculo(){
            Console.Write("Digite a placa do veículo para remover: ");
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int quantidadeHoras = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * quantidadeHoras);

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else{
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos(){
            // Verifica se há veículos no estacionamento
            if (veiculos.Any()){
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("Os veículos estacionados são: ");

                foreach(var item in veiculos){
                    Console.WriteLine(item);
                }
            }
            else{

                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
