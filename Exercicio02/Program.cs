using System;

namespace _Exercicio02
{
    class Program : InfoUsuario
    {
        static void Main(string[] args)
        {
            Metro3 M = new Metro3();
            Teste T = new Teste(M);
            Program P = new Program();

            P.ColetarNomeUsuario();

            bool sucesso1, sucesso2, sucesso3;

            do
            {
                double altura;
                System.Console.WriteLine("Digite a altura do seu espaço: ");
                string? info1 = Console.ReadLine();
                sucesso1 = double.TryParse(info1, out altura);
                if (sucesso1)
                {
                    M.SetAltura(altura);
                }
                else
                {
                    System.Console.WriteLine("Digite uma altura válida!");
                }
            } while (!sucesso1);

            do
            {
                double largura;
                System.Console.WriteLine("Digite a largura do seu espaço: ");
                string? info2 = Console.ReadLine();
                sucesso2 = double.TryParse(info2, out largura);
                if (sucesso2)
                {
                    M.SetLargura(largura);
                }
                else
                {
                    System.Console.WriteLine("Digite uma largura válida!");
                }
            } while (!sucesso2);


            do
            {
                double comprimento;
                System.Console.WriteLine("Digite o comprimento do seu espaço: ");
                string? info3 = Console.ReadLine();
                sucesso3 = double.TryParse(info3, out comprimento);
                if (sucesso3)
                {
                    M.SetComprimento(comprimento);
                }
                else
                {
                    System.Console.WriteLine("Digite um comprimento válido!");
                }

            } while (!sucesso3);

            M.mensagem();
            T.mensagemAN();
            T.mensagemT();
             if(!string.IsNullOrEmpty(P.nomeUsuario))
             {
                Console.WriteLine("Obrigado por usar nosso programa "+P.nomeUsuario+"!");
             }
        }
    }
}