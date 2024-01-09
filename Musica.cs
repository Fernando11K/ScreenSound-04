
using System.Text.Json.Serialization;

namespace ScreenSound_04;
internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; }

    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao/1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }

    //public string RetornarTonalidade() 
    //{ 
    //    Dictionary<int, string> tonalidades = new Dictionary<int, string>();
    //    tonalidades.Add(0, "C");
    //    tonalidades.Add(1, "C#");
    //    tonalidades.Add(2, "D");
    //    tonalidades.Add(3, "D#");
    //    tonalidades.Add(4, "E");
    //    tonalidades.Add(5, "F");
    //    tonalidades.Add(6, "F#");
    //    tonalidades.Add(7, "G");
    //    tonalidades.Add(8, "G#");
    //    tonalidades.Add(9, "A");
    //    tonalidades.Add(10, "A#");
    //    tonalidades.Add(11, "B");
    //    return tonalidades[Key];
        
    //}
}
