using ScreenSound_04;

internal class LinqFilter
{
	public static void FiltarTodosOsGenerosMusicais(List<Musica> musicas) 
	{
		var todosOsGenerosMusicais = musicas.Select(musica =>
        musica.Genero).Distinct().ToList();
		foreach (var genero in todosOsGenerosMusicais) 
		{
		Console.WriteLine($"- {genero}");
		}
		
	}
	public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
	{ 
		var artistasPorGeneroMusical = musicas.Where(musica => 
		musica.Genero!.Contains(genero)).Select(musica => 
		musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

		foreach(var artista in artistasPorGeneroMusical)
		{
            Console.WriteLine($"- {artista}");
        }

    }

	public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista) 
	{
		var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
	public static void FiltrarMusicasTonalidadeSustenido(List<Musica> musicas) 
	{
		var musicasDoArtista = musicas
			.Where(musica => musica.Tonalidade.Equals("C#"))
			.Select(musica => musica.Nome).ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");            
        }

    } 

}
