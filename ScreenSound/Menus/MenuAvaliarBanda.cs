
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{

    public override void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
       base.Execute(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");

            //converte uma nota ( algo que foi digitadi ) , para inteiro e na linha de baixo novamente para texto tipo avaliaçao
            Avaliaçao nota = Avaliaçao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            //bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
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
