using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Player
    {
        public int x;
        public int y;

        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Render()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write('X');
        }
    }
}
