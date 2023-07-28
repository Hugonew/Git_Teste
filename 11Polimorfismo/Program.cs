using System;


namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia Estagiário
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            System.Console.WriteLine("------------");
            // Instancia Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
            System.Console.WriteLine("------------");
            // Instancia Atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
            System.Console.WriteLine("------------");
        }
    }
}