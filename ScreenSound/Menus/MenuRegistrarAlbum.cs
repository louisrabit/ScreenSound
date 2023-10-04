﻿
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Execute(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        /**
         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
         */
        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }

}
