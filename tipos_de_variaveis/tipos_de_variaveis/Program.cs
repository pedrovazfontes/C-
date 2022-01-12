using System;

namespace tipos_de_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {   

            //int i = 1; //tipagem estatica
            //i = s;

            var x = 2; //tipagem dinamica
            //x = "s";

            char t = 'B';

            string t2 = "B";


            //string s = "Pedro";

            var s2 = "Pedro2";

            var f = 1.5f;
            float f2 = 1.5f;

            var d = 1.5;
            double d2 = 1.5;

            var bo = true;
            var bo2 = false;

            bool bol = true;
            bool bol2 = false;


            bool boolean = bool.Parse("false");
            bool bolean2 = Convert.ToBoolean("false");

            //Conversão de objeto para outro objeto/variavel, usa convert
            // Conversão de string para boolean, usa parse(sempre recebe string)





           





            Console.WriteLine(t);
            Console.WriteLine(t2);

        }
    }
}
