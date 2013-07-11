using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelikecandyland
{
    public class Creature
    {

        public Creature(Vector2 pos)
        {
            Creatures(pos);
        }

        static void Creatures(Vector2 pos)
        {
            String creature = "¥";
            //Random rnd = new Random();
            //Vector2 velocity = new Vector2(rnd.Next(0, 50), rnd.Next(0, 50));
            //Console.SetCursorPosition(pos.X, pos.Y);



            for (int i = 0; i <= 100; i++)
            {
                Random richtung = new Random();

                pos += new Vector2(richtung.Next(-1, 2), richtung.Next(-1, 2)); // (x,y)
                Console.SetCursorPosition(pos.X, pos.Y);
                Console.WriteLine(creature);
                Thread.Sleep(500);
                Console.Clear();

            }


            Console.ReadLine();
        }
    }
}