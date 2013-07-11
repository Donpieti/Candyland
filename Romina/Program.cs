using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String creature = "¥";
            Random rnd = new Random();
            Vector2 velocity = new Vector2(rnd.Next(0, 50), rnd.Next(0, 50));
            Console.SetCursorPosition(velocity.X, velocity.Y);
           
            for (int i = 0; i <= 100; i++) 
            {
                velocity += new Vector2(1, 1); // (x,y)
                Console.SetCursorPosition(velocity.X, velocity.Y);
                Console.WriteLine(creature);
                Thread.Sleep(500);
                Console.Clear();               
            }
             Console.ReadLine();
        }
    }
}
