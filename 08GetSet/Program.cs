using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p = new Pessoa();
            p.Nome = "Hugo";
            System.Console.WriteLine(p.Nome);
        }
    }
}
/*
   Se quiser somente enviar uma informação, usar some Set,
   caso queria só obter informação use Get. mas também pode 
   usar os dois. Essa é uma maneira de acessar um atributo PRIVADO */