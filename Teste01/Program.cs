using System;

namespace _Teste01
{
  public class Program
{
    static void Main(string[] args)
    {
        static int Somar(int a, int b)
    {
        return a + b;
    }
        int resultado = Somar(3, 4);
        Console.WriteLine(resultado);   
    }
}
}