﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roguelikecandyland
{
    class main
    {
        static void Main(string[] args)
        {
            GameManager gm = new GameManager();
            GameManager.map.Render();
            Console.CursorVisible = false;
            while (true)
            {
                Console.SetCursorPosition(GameManager.player.x, GameManager.player.y);
                GameManager.player.Move();
                GameManager.player.Render();
                
               
               
            }

            

        }

    }
}
