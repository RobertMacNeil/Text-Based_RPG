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
        //holds map array
        private string[,] map;

        //variables held to get boundries
        private int rows;
        private int columns;

        public Map()
        {
        }

        //method to load in txt files as maps
        public void MapLoader(string filePath)
        {
            //reads in each line
            string[] lines = File.ReadAllLines(filePath);
            //using lines to find number of rows there are
            //using first line to find out how many columns there are
            string firstLine = lines[0];
            rows = lines.Length;
            columns = firstLine.Length;

            //filling map array
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

        // method to display map
        public void Draw()
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public bool MoveCheck(int x, int y)
        {
            //Check bounds first
            if(x < 0 || y < 0 || x >= columns || y >= rows)
            {
                return false;
            }

            //check if grid is walkable
            return map[y, x] == " ";
        }
    }
}
