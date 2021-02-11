using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Based_RPG
{
    class Map
    {
        private string[,] map;

        public Map()
        {
        }

        public void MapLoader(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string firstLine = lines[0];
            int rows = lines.Length;
            int columns = firstLine.Length;

            map = new string[rows, columns];
            for (int y = 0; y < rows; y++)
            {
                string line = lines[y];
                for (int x = 0; x < columns; x++)
                {
                    char currentChar = line[x];
                    map[y, x] = currentChar.ToString();
                }
            }
        }

        public void Draw()
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Console.WriteLine();
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Console.Write(map[x, y]);
                }
            }
            Console.WriteLine();
        }
    }
}
