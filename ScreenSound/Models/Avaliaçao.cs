namespace ScreenSound.Models;


//visibilidade de classes 

internal class Avaliaçao
{
    public Avaliaçao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliaçao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliaçao(nota);
    }
}
