using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Robert's text based RPG");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey(true);

            //initilize gamemanager and run the start of the game
            GameManager gameManager = new GameManager();
            gameManager.StartGame();
        }
    }
}
