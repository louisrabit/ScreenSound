using ScreenSound.Menus;
using ScreenSound.Models;
//using OpenAI_API;

//var client = new  OpenAI_API("Por aqui a chave que do openai")

Banda ira = new Banda("Ira!");
ira.AdicionarNota(new Avaliaçao(10));
ira.AdicionarNota(new Avaliaçao(8));
ira.AdicionarNota(new Avaliaçao(6));
Banda beatles = new Banda("The Beatles!");
beatles.AdicionarNota(new Avaliaçao(10));
beatles.AdicionarNota(new Avaliaçao(8));
beatles.AdicionarNota(new Avaliaçao(6));
//Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);


//tipo da chave é um inteiro (int) , opçao que queremoms achar 
//valor , objecto do tipo Menu 
Dictionary<int, Menu> opcoes = new();
//popular dicionario 
opcoes.Add(1, new MenuRegistrarBanda()); 
opcoes.Add(2, new MenuRegistrarAlbum()); 
opcoes.Add(3, new MenuMostrarBandas()); 
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(6, new MenuAvaliarAlbum());
opcoes.Add(7, new MenuSair());




void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu() 
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma Album");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    

    if(opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuExibido = opcoes[opcaoEscolhidaNumerica];
        menuExibido.Execute(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else 
    {
        Console.WriteLine("Opção inválida");
    }
    Menu menu = opcoes[opcaoEscolhidaNumerica];

}

ExibirOpcoesDoMenu();