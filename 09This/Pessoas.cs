using System;

class Pessoas
{

    // Atributo 
    private string nome= "Tatiana";

    // Construtor
    public Pessoas(string nome) /* (string nome) == Parâmetro */
    {
        System.Console.WriteLine(nome);
        System.Console.WriteLine(this.nome); /* This sempre vai obter/ligar
        o atributo da classe ao método, quando bater o olho se tiver um this
        já sabemos que isso se remete a um atributo*/
    }
}