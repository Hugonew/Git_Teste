using System;


class Atendente : Imposto
{
    
    public override void valeAlimentacao(double salario)
    {
        System.Console.WriteLine("Desconto atendente vale alimentação R$"+(salario *0.12 ));
    }

}