using System;

class Metro3
{
    private double altura, comprimento, largura;

    public void SetAltura(double altura)
    {
        this.altura = altura;
    }

    public void SetComprimento(double comprimento)
    {
        this.comprimento = comprimento;
    }

    public void SetLargura(double largura)
    {
        this.largura = largura;
    }

    public double calculo()
    {
        return altura * comprimento * largura;
    }


    public string conclusao(double espaco)
    {
        if (espaco < 75)
        {
            return "Espaço de tipo 1";
        }
        else if (espaco < 100)
        {
            return "Espaço de tipo 2";
        }
        else
        {
            return "Espaço de tipo 3";
        }
    }

    public void mensagem()
    {
        double obterCalculo = calculo();
        string obterConclusao = conclusao(obterCalculo);

        System.Console.WriteLine("Seu espaço é de " + obterCalculo + "m³");
        System.Console.WriteLine(obterConclusao);
    }
}
