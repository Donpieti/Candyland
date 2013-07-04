using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelikecandyland
{
    class Einlesen
    {
        public void Editormap()
        {
            Map map = new Map(58, 24);
            Player player = new Player(10, 10);

            map.LoadFromFile(@"E:\Candyland\Patty\Text.txt");
            map.Render();
            player.Render();
            Console.ReadKey();
            player.x += 1;
            map.RenderField(player.x - 1, player.y);
            player.Render();
            Console.ReadKey();
        }

        internal void Editortext()
        {
            throw new NotImplementedException();
        }
    }
}