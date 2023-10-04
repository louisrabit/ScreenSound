using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
 