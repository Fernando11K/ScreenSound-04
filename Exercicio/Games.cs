

namespace ScreenSound_04.Exercicio;

internal class Games {
   public async static Task<string> GetSharkCreap()
    {
        using (HttpClient client = new HttpClient())
        {
            try { 
            
                string retorno = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
                return retorno;
            } 
            catch (Exception ex) { 
                Console.WriteLine($"Ocorreu uma exceção: { ex.Message}");
                return null;
            }
        }
    }

    
}
