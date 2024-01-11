using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("╔══════════════════════════════════════════════════╗");
Console.WriteLine("║   Seja bem vindo ao sistema de estacionamento!   ║");
Console.WriteLine("╚══════════════════════════════════════════════════╝");

Console.Write("Digite o valor inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("--------------------------------------------");
Console.Write("Informe o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("--------------------------------------------");

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while(exibirMenu){
    Console.Clear();
    Console.WriteLine("Escolha uma opção abaixo:\n");
    Console.WriteLine("[1] - Cadastrar veículo");
    Console.WriteLine("[2] - Remover veículo");
    Console.WriteLine("[3] - Listar veículos");
    Console.WriteLine("[4] - Encerrar");

    switch (Console.ReadLine()){
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}


Console.WriteLine("--------------------------------");
Console.WriteLine("   ...Finalizando aplicação...\t");
Thread.Sleep(1200);
Console.WriteLine("Aplicação finalizada com sucesso!");
Console.WriteLine("--------------------------------");
