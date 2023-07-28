using System;

public class InfoUsuario
{
    protected string? nomeUsuario;
    
    public void ColetarNomeUsuario()
    {
        System.Console.WriteLine("Digite o seu nome: ");
        nomeUsuario = Console.ReadLine();
    }
}