using System;


class Individuo
{

    // Atributo

    /* Quando usamos o Protected, apenas a classe que
     é criado aquele atributo ou método, pode ultilizar, além de classes que estendem
     que vão herdar a classe Individuo no caso*/

    protected  string? nome;
    protected int idade;

    // Método
    protected void mensagemPessoa()
    {
        System.Console.WriteLine("Nome: "+nome);
        System.Console.WriteLine("Idade "+idade);
        
    }

}