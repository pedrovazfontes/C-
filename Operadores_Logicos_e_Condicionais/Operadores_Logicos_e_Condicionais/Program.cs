using System;

namespace Operadores_Logicos_e_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao questionário");
            Console.WriteLine("Por meio deles, iremos liberar o acesso ou não");

            Console.WriteLine("Digite seu nome");
            string nome;
            nome = Console.ReadLine();

            Console.WriteLine("Digite o ano atual");
            string ano1;
            ano1 = Console.ReadLine();
            int anoatual = Int32.Parse(ano1);

            Console.WriteLine("Digite o ano de nascimento do visitante");
            string ano2;
            ano2 = Console.ReadLine();
            int anonascimento = Int32.Parse(ano2);

            int idade = anoatual - anonascimento;

            Console.WriteLine("O visitante tem " + idade + " anos");

            if (idade >= 18)
            {
                Console.WriteLine("O visitante pode entrar");
            }
            else
            {
                Console.WriteLine("Infelizmente não poderá entrar, informar ao visitante");
            }

        }
    }
}
