using ScreenSound_04;

internal class LinqFilter
{
	public static void FiltarTodosOsGenerosMusicais(List<Musica> musicas) 
	{
		var todosOsGenerosMusicais = musicas.Select(generos => 
		generos.Genero).Distinct().ToList();
		foreach (var genero in todosOsGenerosMusicais) 
		{
		Console.WriteLine($"-{genero}");
		}
	}
}
