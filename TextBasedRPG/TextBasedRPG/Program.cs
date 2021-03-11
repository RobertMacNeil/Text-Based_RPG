using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Robert's Text Based RPG");
            Console.WriteLine("Press any key to start your quest...");

            Console.ReadKey(true);

            GameManager gameManager = new GameManager();
            gameManager.StartGame();
        }
    }
}
