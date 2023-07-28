using System;

class Pessoa
{
    public double peso, altura;

    public double calculo()
    {
        return peso/(altura*altura);
    }

    public string situacao(double imc)
    {
        if (imc <= 18.5)
        {
            return "Abaixo do peso";
        }
        else if (imc <= 25)
        {
            return "Peso normal";
        }
        else if (imc <= 30)
        {
            return "Acima do peso";
        }
        else if (imc <= 35)
        {
            return "Obesidade I";
        }
        else if (imc <= 40)
        {
            return "Obesidade II";
        }
        else
        {
            return "Obesidade III";
        }
    }

    public void mensagem()
    {
        double obterCalculo = calculo();
        string obterSituacao = situacao(obterCalculo);

        System.Console.WriteLine("Seu IMC é de "+obterCalculo);
        System.Console.WriteLine("Com esse peso vc está na seguinte situação:"+obterSituacao);
    }
}