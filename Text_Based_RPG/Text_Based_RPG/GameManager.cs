using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class GameManager
    {
        public void StartGame()
        {
            //initialize primary characters to use
            //the map has a method to load in txt files -
            //-granting easier access to things such as potential levels
            Map map = new Map();
            map.MapLoader("Map.txt");
            
            Player player = new Player(map);
            Enemy enemy = new Enemy(map);

            //the gameloop
            while (true) // remember to set up with player lives
            {
                Console.Clear();

                map.Draw();
                enemy.Draw();
                player.Draw(); // drawn last

                player.Update(); // updated first takes input
                enemy.Update();
            }

        }
    }
}
