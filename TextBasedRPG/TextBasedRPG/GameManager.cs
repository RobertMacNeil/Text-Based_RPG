using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class GameManager
    {
        public void StartGame()
        {
            //init pieces of games
            Map map = new Map();
            map.MapLoader("Map.txt");

            Player player = new Player(map);

            while(player.Lives >= 1)
            {
                map.Draw();
                player.Draw();

                player.Update();
            }
        }
    }
}
