using System;
using System.Collections.Generic;

namespace Funcoes
{
    class Program
    {

        public static float CalculaMedia(float nota1, float nota2, float nota3, float nota4)
        {
            float media = (nota1 + nota2 + nota3 + nota4) / 4;
            return media;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema da escola Colegio BR");
            Console.WriteLine("De acordo com as opções mostras abaixo, informe a desejada:");
            Console.WriteLine("[1] - Verificar se aluno foi aprovado ou não");
            Console.WriteLine("[2] - Cadastrar Notas");
            Console.WriteLine("[3] - Sair do Sistema");

            string opcao = Console.ReadLine();
            while (opcao != "3")
            {
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite a primeira nota: ");
                        float n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a segunda nota: ");
                        float n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a terceira nota: ");
                        float n3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a quarta nota: ");
                        float n4 = Convert.ToInt32(Console.ReadLine());
                        float media = CalculaMedia(n1,n2,n3,n4);
                        if (media >= 6)
                        {
                            Console.WriteLine("Aluno aprovado!!!");
                        }
                        else
                        {
                            Console.WriteLine("Aluno REPROVADO!!");
                        }
                        break;


                    default:
                        Console.WriteLine("ok");
                        break;
                      

                }
            }
        }
    }
}
