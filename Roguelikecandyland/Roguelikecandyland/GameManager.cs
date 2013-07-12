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

        public static collision collision;

        public GameManager()
        {
            player = new Player(10, 10);
            map = new Map(58, 24);
            collision = new collision();
            string path = "Text.txt";
            string fullPath = System.IO.Path.GetFullPath(path);
            map.LoadFromFile(fullPath);
        }
    }
}
