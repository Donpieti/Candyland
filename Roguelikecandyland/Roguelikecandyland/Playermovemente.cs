using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace Roguelikecandyland
{
    class Playermovemente
    {
        public bool Move(Player player)
        {
            int x = 0;
            int y = 0;

            ConsoleKeyInfo key;

            if (!Console.KeyAvailable)
            {
                return false;
            }
             
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    x -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    x += 1;
                    break;
                case ConsoleKey.UpArrow:
                    y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    y += 1;
                    break;
            }

            player.x += x;
            player.y += y;

            return ((x != 0) || (y != 0));
        }
    }
}