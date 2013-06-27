using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Map
    {
        private Field[,] map;

        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            map = new Field[height, width];
            Width = width;
            Height = height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    map[y, x] = new Field();
                }
            }
        }

        public Field GetField(int x, int y)
        {
            return map[y - 1, x - 1];
        }

        public void LoadFromFile(string FileName)
        {
            string[] lines = System.IO.File.ReadAllLines(FileName);
            for (int line = 0; line < lines.Length; line++)
            {
                for (int c = 0; c < lines[line].Length; c++)
                {
                    map[line, c].Text = lines[line].ToCharArray()[c];
                    if (map[line, c].Text == ',')
                    {
                        map[line, c].Text = '.';
                        map[line, c].Color = ConsoleColor.Red;
                    }
                }
            }
        }

        public void Render()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = map[y, x].Color;
                    Console.Write(map[y, x].Text);
                }
            }
        }

        public void RenderField(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = map[y, x].Color;
            Console.Write(map[y, x].Text);
        }

    }
}
