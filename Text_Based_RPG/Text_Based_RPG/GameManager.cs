using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class GameManager
    {
        public GameManager()
        {
        }

        public void StartGame()
        {
            Map map = new Map();
            Player player = new Player();
            Enemy enemy = new Enemy();
            
            while(true) // remember to set up with player lives
            {
                Console.Clear();

                map.Draw();
                //player.Draw();
                //enemy.Draw();

                //player.Update();
                //enemy.Update();
                Console.ReadKey();
            }

        }
    }
}
