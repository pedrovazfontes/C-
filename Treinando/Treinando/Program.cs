using System;
using System.Collections.Generic;

namespace Treinando
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = opcoes();
            
            while(opcao != "3")
            {
                switch (opcao)
                {
                    case "1":
                        //Cadastrar carro
                        List<string> carrosdisponiveis = new List<string>();
                        Console.WriteLine("Digite o nome do carro: ");
                        string carro = Console.ReadLine();
                        carrosdisponiveis.Add(carro);
                        Console.WriteLine(carrosdisponiveis[0]);
                        break;
                    case "2":
                        //Vender/Remover carro
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcao = opcoes();

            }
        }

        private static string opcoes()
        {
            Console.WriteLine("Olá, seja bem-vindo");
            Console.WriteLine("Este e o sistema de Venda de veiculos");
            Console.WriteLine("De acordo com as oções desejadas, realize a função pretendida");
            Console.WriteLine("1 [Cadastra Carro]");
            Console.WriteLine("2 [Venda de Veiculos]");
            Console.WriteLine("3 [Sair de Prorama]");
            string opcao;
            opcao = Console.ReadLine();
            return opcao;
        }
    }
}
