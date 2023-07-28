using System;


class Aluno
{
    // Atributos

    private double nota1, nota2;

    // Média
    private double media()
    {
        return (nota1+nota2)/2;
    }

    public void mensagem()
    {
        System.Console.WriteLine("Informe a primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Informe a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("A média é "+media());
    }
}