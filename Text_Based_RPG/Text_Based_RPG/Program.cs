using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * notes: 
 * program inits gamemanager and runs the startgame
 * gamemanager's startgame inits game pieces (map player enemy(ies)) loads map and holds gameloop (draw->update)
 * map has the maploader and draw method as well as holds method to detect contact (boundaries)
 * 
 * gamecharacter holds any similar values and methods game characters would have
 * player and enemy inherit gamecharacter and have their own movements
 */

namespace Text_Based_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.WriteLine("Welcome to Robert's text based RPG");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey(true);
            Console.Clear();

            //initilize gamemanager and run the start of the game
            GameManager gameManager = new GameManager();
            gameManager.StartGame();
        }
    }
}
