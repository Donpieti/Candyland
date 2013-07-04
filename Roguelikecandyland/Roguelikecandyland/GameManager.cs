using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roguelikecandyland
{
    public class GameManager
    {
        public static Player player;

        public static Map map;

        public GameManager()
        {
            player = new Player(10, 10);
            map = new Map(58, 24);

            map.LoadFromFile(@"C:\Users\kawiegmann\Desktop\Neuer Ordner\Text.txt");
        }
    }
}
