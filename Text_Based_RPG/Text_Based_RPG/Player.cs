using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    // inherits gamecharacter
    class Player : GameCharacter
    {
        public Player()
        {
            //constructor sets base variables
            name = "Player";
            token = 'P';
            maxHealth = 100;
            maxShield = 100;
            health = 100;
            shield = 100;
            lives = 3;
            x = 1;
            y = 1;
        }

        public void Update(Map currentMap, Enemy enemy)
        {
            if (alive == false) return;

            ConsoleKeyInfo input;

            input = Console.ReadKey(true);
            while (Console.KeyAvailable)
            input = Console.ReadKey(true);


            switch (input.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if((enemy.x == x) && (enemy.y == y-1) && enemy.Alive)
                    {
                        enemy.TakeDamage(5);
                    }
                    else if (currentMap.MoveCheck(x,y-1))
                    {
                        MoveUp();
                    }
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if ((enemy.x == x) && (enemy.y == y + 1) && enemy.Alive)
                    {
                        enemy.TakeDamage(5);
                    }
                    else if(currentMap.MoveCheck(x, y + 1))
                    {
                        MoveDown();
                    }
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if ((enemy.x == x - 1) && (enemy.y == y) && enemy.Alive)
                    {
                        enemy.TakeDamage(5);
                    }
                    else if (currentMap.MoveCheck(x - 1, y))
                    {
                        MoveLeft();
                    }
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if ((enemy.x == x + 1) && (enemy.y == y) && enemy.Alive)
                    {
                        enemy.TakeDamage(5);
                    }
                    else if (currentMap.MoveCheck(x + 1, y))
                    {
                        MoveRight();
                    }
                    break;
                default:
                    Update(currentMap, enemy);
                    break;
            }
        }
    }
}
