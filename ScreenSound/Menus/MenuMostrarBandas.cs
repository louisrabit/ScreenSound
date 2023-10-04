
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuMostrarBandas : Menu
{
    public override void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Execute(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }

}
