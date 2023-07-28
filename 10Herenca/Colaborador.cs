using System;

class Colaborador : Individuo /* Indicador de herança " : " Obs: não existe herança multipla,
 uma classe não pode extender duas classes duas ou mais. Regra para c# java e php */
{

    // Atributos
    private double salario;

    // Contrutor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    // Método
    private void mensagemColaborador()
    {
        System.Console.WriteLine("Salário: "+salario);
    }
}