using System;

class Teste
{
    private Metro3 M;
    private double areaNconstruida, opcao = 0;

    public Teste(Metro3 metro3)
    {
        M = metro3;
    }

    public void mensagemAN()
    {
        System.Console.WriteLine("Digite em m³ sua área não construida: ");
        string? info4 = Console.ReadLine();
        bool sucesso4 = double.TryParse(info4, out opcao);

        if (sucesso4)
        {
            areaNconstruida = opcao;
        }
    }

    public double areaConstruida()
    {
        return M.calculo() - opcao;
    }

    public void mensagemT()
    {
        double obterInfo = areaConstruida();
        System.Console.WriteLine("Sua total área construida é de " + obterInfo +"m³");
    }
}