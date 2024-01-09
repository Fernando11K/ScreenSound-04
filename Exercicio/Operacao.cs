using System;
using System.Security.Cryptography.X509Certificates;

namespace ScreenSound_04.Exercicio;

internal class Operacao
{
    public static void Dividir() {
        int resultado = 0;
        try
        {
            Console.Write("Digite o valor a ser dividido: ");
            int dividendo = int.Parse(Console.ReadLine());
            Console.Write("Digite o divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            resultado = dividendo / divisor;
        }
        catch (DivideByZeroException e) {
            Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0.");
        }      

    }
    public static void Lista() {
          List<int> lista = new() { 1, 2, 3 };
        try 
        {         
            Console.Write("Digite o índice do elemento a ser buscado: ");
            var index = int.Parse(Console.ReadLine());
             Console.Write($"Elemento de índice {index}: {lista[index]}");
        }
        catch (Exception e)
        {
            Console.WriteLine($" Índice inexistente {e.Message}");
        }        
    }

}

