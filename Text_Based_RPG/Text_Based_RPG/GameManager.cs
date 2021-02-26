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

            Hud hud = new Hud();
            
            Player player = new Player();
            Enemy[] enemies = new Enemy[1];
            enemies[0] = new Enemy();

            //Map learns player and Enemy location

            //the gameloop
            while (true) // remember to set up with player lives
            {
                Console.Clear();

                map.Draw();
                //hud.Draw();
                foreach (Enemy enemy in enemies)
                {
                    enemy.Draw();
                }
                player.Draw(); // drawn last

                player.Update(map); // updated first takes input
                foreach (Enemy enemy in enemies)
                {
                    enemy.Update(map);
                }
            }

        }
    }
}
