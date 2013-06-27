using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pipikaka = "~#*♥ CaNdYlAnD ♥*#~";

            // Color = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i <= 100; i++)
            {
                Random random = new Random();
                int x = random.Next(0, 50);
                int y = random.Next(0, 50);
                Console.SetCursorPosition(x, y);
                Console.WriteLine(pipikaka);
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}