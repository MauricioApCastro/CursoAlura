//criar uma string com a mensagem de boas vindas e mostrar no console
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
Console.WriteLine(mensagemDeBoasVindas);
List<string> bandas = new List<string>();

void ExibirTitulo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░  
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

//método do menu
void Menu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.WriteLine("\nEscolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2: Console.WriteLine("você escolheu a opção " + opcao);
           MostrarBandas();
            break;
        case 3: Console.WriteLine("você escolheu a opção " + opcao); break;
        case 4: Console.WriteLine("você escolheu a opção " + opcao); break;
        case -1: Console.WriteLine("Até mais " + opcao); break;
        default: Console.WriteLine("Opção inválida"); break;


    }


}
void RegistrarBanda()
{
   
    Console.Clear();
    ExibirTitulo();
    ExibirCabecalho("Registrar Banda");
    Console.WriteLine("Digite o nome da Banda: ");
    string nomeDaBanda = Console.ReadLine();
    bandas.Add(nomeDaBanda);

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!! ");
    Thread.Sleep(2000);
    Console.Clear();
    
    ExibirTitulo();
    Menu(); 
}
void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo();
    ExibirCabecalho("Listar Bandas");
    foreach (var banda in bandas)
    {
        Console.WriteLine($"banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirTitulo();
    Menu();
}

void ExibirCabecalho(string titulo)
{
    int tamanhoTitulo = titulo.Length;
    string asterisco = string.Empty.PadLeft(tamanhoTitulo, '*');
    Console.WriteLine("\n"+asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco+"\n");

}
ExibirTitulo();
Menu();

