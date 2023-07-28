using System;


namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double opcao;
           Pessoa e = new Pessoa();
           System.Console.Write("Digite seu peso atual: ");
           string? procedimento=Console.ReadLine();
           bool sucesso = double.TryParse(procedimento, out opcao);
           if(sucesso)
           {
            e.peso = opcao;
           }

           else
           {
            System.Console.WriteLine("Peso inválido");
           }

            double opcao2;
           System.Console.WriteLine("Digite sua altura atual: ");
           string? dado=Console.ReadLine();
           bool sucesso2 = double.TryParse(dado, out opcao2);
           if(sucesso2)
           {
            e.altura = opcao2; // usar "," ao executar o programa
           } 

           else
           {
            System.Console.WriteLine("Altura inválido");
           }
           
           e.mensagem();
        }
    }
}