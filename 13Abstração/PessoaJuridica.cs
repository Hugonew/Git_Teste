using System;

class PessoaJuridica : Padrao
{
    // Método obrigatório

    public override void taxaEmprestimo(double valor)
    {
        System.Console.WriteLine("Taxa de emprétimo para Pessoa Jurídica R$ "+(valor * 0.2));
    }
}