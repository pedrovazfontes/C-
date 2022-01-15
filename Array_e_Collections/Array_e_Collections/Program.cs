using System;
using System.Collections.Generic;

namespace Array_e_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[3]; //estatica
            a[0] = "Danilo";
            a[1] = "Pedro";
            a[2] = "Joao";

            int size = a.Length; //quantidade
            
            foreach(string nome in a)// ao lado do a podemos colocar um .Order by e estipular uma ordem asc desc
            {
                Console.WriteLine(nome);
            }

            //Console.WriteLine(String.Join("\n", a));
            /*O String.Join() método concatena os elementos de um array especificada com um separador
             * especificado entre eles em C#*/


            List<string> c = new List<string>();
            c.Add("Danio");
            c.Add("Sheila");
            c.Add("Lana");
            Console.WriteLine(c[0]);

            int size_list = c.Count;//quantidade
        }
    }
}
