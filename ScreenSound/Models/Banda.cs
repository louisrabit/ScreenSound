 namespace ScreenSound.Models;

internal class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliaçao> notas = new List<Avaliaçao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    // aqui seria Avaliaçao .Nota  
    // a => a.nota   ( class que tem varias propriedades , tem que se indicar qual vamos fazer a media )
    //Expressao lambda, paras cada avaliaçao use a propriedade nota 
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliaçao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}