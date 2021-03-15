using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class Player : GameCharacter
    {
        Map map;
        public Player(Map map)
        {
            avatar = 'P';
            maxHealth = 100;
            health = 100;
            maxSheild = 100;
            shield = 100;
            lives = 3;
            x = 1;
            y = 1;
            this.map = map;
        }

        public void Update()
        {

            ConsoleKeyInfo input = Console.ReadKey();
            
            switch(input.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if(map.MoveCheck(x, y - 1))
                    {
                    MoveUp();
                    }
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if(map.MoveCheck(x, y + 1))
                    {
                    MoveDown();
                    }
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    if (map.MoveCheck(x - 1, y))
                    { 
                    MoveLeft();
                    }
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if (map.MoveCheck(x + 1, y))
                    { 
                    MoveRight();
                    }
                    break;
                default:
                    Update();
                    break;
            }
        }
    }
}
