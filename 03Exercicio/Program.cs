using System;

namespace _03Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instanciar objeto da class Aluno
            Aluno a = new Aluno();
            a.nome = "Dênis";
            a.nota1 = 2;
            a.nota2 = 5;
            a.mensagem();
        }
    }
}