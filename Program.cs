using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            String Texto;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Você fala: ");
            Console.ResetColor();
            Texto = Console.ReadLine();
            { // ---Mudanças
            Texto = Texto.Replace("A", "4");
            Texto = Texto.Replace("a", "4");
            Texto = Texto.Replace("E", "3");
            Texto = Texto.Replace("e", "3");
            Texto = Texto.Replace("I", "1");
            Texto = Texto.Replace("i", "1");
            Texto = Texto.Replace("L", "1");
            Texto = Texto.Replace("l", "1");
            Texto = Texto.Replace("O", "0");
            Texto = Texto.Replace("o", "0");
            Texto = Texto.Replace("T", "7");
            Texto = Texto.Replace("t", "7");
            Texto = Texto.Replace("S", "5");
            Texto = Texto.Replace("s", "5");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("No Leet se fala: ");
            Console.ResetColor();
            Console.WriteLine(Texto);
            Console.WriteLine();
        }
    }
}
