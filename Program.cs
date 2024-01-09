using ScreenSound_04.Exercicio;

using (HttpClient client = new HttpClient())
{
    var retorto = await Games.GetSharkCreap();
    Console.WriteLine(retorto);

}
Operacao.Dividir();
Operacao.Lista();