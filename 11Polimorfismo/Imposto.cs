using System;


class Imposto
{
    
    // Métodos
    public virtual void valeAlimentacao(double salario)
    {
        System.Console.WriteLine("Desconto padrão do vale alimentação R$"+(salario*0.1));
    }

    public void valeTransporte (double salario)
    {
        System.Console.WriteLine("Desconto padrão do vale transporte R$"+(salario * 0.06));
    }
}