using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L02A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ut 25 rader
            for (int row = 0; row < 25; row++)
            {
                // Infoga mellanslag vid början av varannan rad
                if (row % 2 == 0)
                {
                    Console.Write(" ");

                }

                // Skriv ut 39 kolumner
                for (int col = 0; col < 39; col++)
                {
                    Console.Write("* ");

                }

                // Ändra färg på rad
                switch (row % 3)
                {
                    case 0: Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case 1: Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case 2: Console.ForegroundColor = ConsoleColor.Green; break;
                }


                Console.WriteLine();
            }
            
        }
    }
}
