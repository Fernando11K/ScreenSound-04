using ScreenSound_04;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine(musicas.Count);
        musicas[1998].ExibirDetalhesDaMusica();
        //LinqFilter.FiltarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas,"pop");
    }
    catch (Exception ex) 
    { 
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
