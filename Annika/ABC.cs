using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        public static Queue<char> Suchliste;

        // Erstelle eine Warteschlange

        static void Main(string[] args)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Suchliste.Enqueue(c);
            }
        // Die Warteschlange wird mit den Buchstaben von A - Z in alphabetischer Reihenfolge befüllt

            char sammelChar;

            if (Suchliste.Peek() == sammelChar)
            {
                Suchliste.Dequeue();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Das ist nicht der richtige Buchstabe!");
            }

        // Wenn der Buchstabe, den man einsammeln will, vorne in der Warteschlange steht, wird der Buchstabe aus der Liste entfernt

            if (Suchliste.Count == 0)
            {
                   {
                      Console.BackgroundColor = ConsoleColor.DarkCyan;
                      Console.Clear();
                      Console.ForegroundColor = ConsoleColor.White;

                       for (int i = 0; i <= 100; i++)
                            {
                                 Random random = new Random();
                                 int x = random.Next(0, 30);
                                 int y = random.Next(0, 30);
                                Console.SetCursorPosition(x, y);
                                Console.WriteLine("Du hast gewonnen!");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                  
                       Console.ReadLine();
                     }
        // Ist die Liste leer, kommt der Win-Screen! :D
             }
               
        }
        }
    }
}
