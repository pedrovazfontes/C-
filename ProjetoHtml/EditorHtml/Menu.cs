using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;//Cor da tela
            Console.ForegroundColor = ConsoleColor.Blue;//Cor da fonte

            
            DrawScreen();
        }

        public static void DrawScreen(){
            Cabecalho();
            Linhas();
            Cabecalho();
    
        }

        public static void Cabecalho(){
            Console.Write("+");
            for (int i = 0; i<=30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

        }

        public static void Linhas(){
            for (int lines = 0;lines<10;lines++){
                    Console.Write("|");
                    for(int i =0;i<=30;i++)
                        Console.Write(" ");
                    
                    Console.Write("|");
                    Console.Write("\n");
                }
        }
        
    }
    
}