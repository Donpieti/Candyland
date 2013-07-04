using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelikecandyland
{
    public class Player
    {

        // NUR das aussehen etc. für den Spieler, keine bewegung 

        private Vector2 oldPosition;
        private Vector2 position;

        public int x
        {
            get { return position.X; }
            set { position.X = Math.Min(Math.Max(0, value), Console.BufferWidth); }
        }

        public int y
        {
            get { return position.Y; }
            set { position.Y = Math.Min(Math.Max(0, value), Console.BufferHeight); }
        }

        Playermovemente bewegung;

        // Einbau von der Playerbewegung, was sich in einen anderen class befindet

        public Player(int x, int y)
        {
            position = new Vector2();
            oldPosition = new Vector2();
            this.x = x;
            this.y = y;
            bewegung = new Playermovemente();
        }

        public void Render()
        {
            // Spieleraussehen. In dem Fall: Sein Standpunkt ist auf X=0 Y=0 Farbe der Figur -> Cyan und sieht so aus-> ☻

            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write('☻');
        }

        public void Move()
        {
            if(bewegung.Move(this))
            {
                GameManager.map.RenderField(oldPosition.X, oldPosition.Y);
                oldPosition = new Vector2(position);
            }
        }        
    }
}