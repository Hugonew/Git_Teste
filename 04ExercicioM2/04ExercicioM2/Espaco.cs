using System;


class Espaco
{
    public double largura, comprimento;

    public double calculo()
    {
        return largura*comprimento;
    }

    string resultado(double m2)
    {
        if (m2 <= 20)
        {
            return "Área de tipo 1";
        }
        else if(m2 <=30)
        {
            return "Área de tipo 2";
        }
        else
        {
            return "Área de tipo 3";
        }
    }
    public void mensagem()
    {
        double obterCalculo= calculo();
        string obterResultado = resultado(obterCalculo);
        System.Console.WriteLine("Sua área é de "+obterCalculo+" metros quadrados");
        System.Console.WriteLine("Que é uma "+obterResultado);
    }
}