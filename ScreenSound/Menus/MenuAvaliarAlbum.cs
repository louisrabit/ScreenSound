
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{

  public override void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Execute(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o titulo do album:");
            string tituloAlbum =  Console.ReadLine()!;  
            if(banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {

                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
               Console.Write($"Qual a nota que a banda {tituloAlbum} merece: ");

                //converte uma nota ( algo que foi digitadi ) , para inteiro e na linha de baixo novamente para texto tipo avaliaçao
                Avaliaçao nota = Avaliaçao.Parse(Console.ReadLine()!);
               
                album.AdicionarNota(nota);
                //bandasRegistradas[nomeDaBanda].Add(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum} da banda {nomeDaBanda}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA ALBUM {tituloAlbum} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();

            }



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


