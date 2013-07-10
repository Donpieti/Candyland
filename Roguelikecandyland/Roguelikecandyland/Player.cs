﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelikecandyland
{
    public class Player
    {
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
            if (validmovement())
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write('☻');
            }
        }

        public Boolean validmovement()
        {
            if (GameManager.map.GetField(position.X+1,position.Y+1).Text == 'o')
            {
                Console.SetCursorPosition(oldPosition.X, oldPosition.Y);
                x = oldPosition.X;
                y = oldPosition.Y;
                return false;
            }
            else
            { 
                return true; 
            }
        }

        public void Move()
        {
            if (bewegung.Move(this))
            {
                if (validmovement())
                {
                    GameManager.map.RenderField(oldPosition.X, oldPosition.Y);
                    oldPosition = new Vector2(position);
                }
            }
        }
    }
}