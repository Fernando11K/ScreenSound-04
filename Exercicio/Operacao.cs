using System;
using System.Security.Cryptography.X509Certificates;

namespace ScreenSound_04.Exercicio;

internal class Operacao
{
    public static double Dividir() {
        double resultado = 0;
        try
        {
            Console.Write("Digite o valor a ser dividido: ");
            double dividendo = double.Parse(Console.ReadLine());
            Console.Write("Digite o divisor: ");
            double divisor =  double.Parse(Console.ReadLine());
            resultado = dividendo / divisor;
        }
        catch (Exception e) { 
            Console.Write($"Ocorreu uma exceção: {e.Message }");
             throw new Exception();
        }
        return resultado;



    }
    public static int Lista() {
            List<int> lista = new() { 1, 2, 3 };
        try 
        {         
            Console.Write("Digite o índice do elemento a ser buscado: ");
            var index = int.Parse(Console.ReadLine());
            return lista[index];
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return 454;
    }

}

