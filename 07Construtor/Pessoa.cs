using System;

class Pessoa
{
    // Construtor
    public Pessoa()
    {
        System.Console.WriteLine("Construtor executado");
    }

    public Pessoa(string nome)
    {
        System.Console.WriteLine("Olá "+nome);
    }
}