using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Execute(bandasRegistradas);//vai executar o que esta no metodo do menu , console.clear e depois executa o que esta aqui
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            //List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            foreach(Album album  in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome}->{album.Media}");
            }
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear(); 
        }
    }
}
