using System;
using System.Globalization; //Utilizando este using, no terminal quando formos digitar o numero double ele irá aceitar o ponto mesmo sendo do Brasil
namespace Entradadedados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {a + b}");

            ////Exercicio 2
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = 3.14159 * (A * A);
            Console.WriteLine($"A = {resultado}");

            ////Exercicio 3
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine($"DIFERENCA = {((c * d)) - (e * f)}");

            //Exercicio 4
            int n_id = int.Parse(Console.ReadLine());
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor_hr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NUMBER = {n_id}");
            Console.WriteLine($"SALARY = ${horas * valor_hr}");


            //Exercicio 5
            int peca1 = int.Parse(Console.ReadLine());
            int qtd = int.Parse(Console.ReadLine());
            double valor_peca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int peca2 = int.Parse(Console.ReadLine());
            int qtd2 = int.Parse(Console.ReadLine());
            double valor_peca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = ((qtd * valor_peca)) + (qtd2 * valor_peca2);
            Console.WriteLine($"VALOR A PAGAR: R${result}");


            //Exercios

        }
    }
}