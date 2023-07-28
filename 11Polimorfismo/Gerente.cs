using System;


class Gerente : Imposto
{

    // Método
    public override void valeAlimentacao(double salario)
    {
        System.Console.WriteLine("Desconto gerente vale alimentação R$"+(salario *0.15 ));
    }

}