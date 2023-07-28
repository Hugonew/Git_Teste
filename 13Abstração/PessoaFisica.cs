using System;

class PessoaFisica : Padrao
{
    // Método obrigatório

    public override void taxaEmprestimo(double valor)
    {
        System.Console.WriteLine("Taxa de emprétimo para Pessoa Física R$ "+(valor * 0.1));
    }
}