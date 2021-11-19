using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue; // cor de fundo 
            Console.ForegroundColor = ConsoleColor.Black; // cor da letra  

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            // linha horizontal  +---------------+
            Console.Write("+");
            for (int i = 0; i <30; i++)
                Console.Write("-");

                Console.Write("+");
                Console.Write("\n");
            // fim linha horizontal.

            // LINHA VERTICAL |
            for(int lines =0; lines <=10; lines++)
            {
                Console.Write("|");
                for (int i=1; i<=30;i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            } // FIM LINHA VERTICAL

            Console.Write("+");
            for (int i = 0; i <30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            
        }
    
        public static void WriteOptions()
        {
            Console.SetCursorPosition(9, 2); // posiciona o cursor na linha e coluna informado
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(6, 3);
            Console.WriteLine("================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");



        }
    
        public static void HandleMenuOption(short option)
        {
            switch(option){
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0: {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }
            default: Show(); break;

            }

        }
    }

}