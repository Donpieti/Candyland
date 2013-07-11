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
        // Class für die Spielerbewegung
        public bool Move(Player player)
        {
            int x = 0;
            int y = 0;

       // Spieler Position! In diesen Fall ist sie auf X=0 und Y=0
            ConsoleKeyInfo key;

            if (!Console.KeyAvailable)
            {
                return false;
            }
            // Wenn die Tasten nicht gedrückt werden, tut sich auch nichts
 
            key = Console.ReadKey();

            // Einstellung für die Spielerbewegung. In dem Fall: LeftArrow -> Drückt man mit der linken Pfeiltaste nach Links bewegt sich die Spielerfigur auf X= -1 usw.

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