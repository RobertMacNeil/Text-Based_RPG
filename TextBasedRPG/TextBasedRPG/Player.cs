using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class Player : GameCharacter
    {
        public Player()
        {
            avatar = 'P';
            maxHealth = 100;
            health = 100;
            maxSheild = 100;
            shield = 100;
            lives = 3;
            strength = 10;
            x = 1;
            y = 1;
        }

        public void Update(Map map, Enemy enemy)
        {
            ConsoleKeyInfo input = Console.ReadKey();
            
            switch(input.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if ((enemy.X == x) && (enemy.Y == y - 1))
                    {
                        enemy.TakeDamage(strength);
                    } 
                    else if(map.MoveCheck(x, y - 1))
                    {
                    MoveUp();
                    }
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if ((enemy.X == x) && (enemy.Y == y + 1))
                    {
                        enemy.TakeDamage(strength);
                    }
                    else if(map.MoveCheck(x, y + 1))
                    {
                    MoveDown();
                    }
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    if ((enemy.X == x - 1) && (enemy.Y == y))
                    {
                        enemy.TakeDamage(strength);
                    }
                    else if(map.MoveCheck(x - 1, y))
                    { 
                    MoveLeft();
                    }
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if ((enemy.X == x + 1) && (enemy.Y == y))
                    {
                        enemy.TakeDamage(strength);
                    }
                    else if(map.MoveCheck(x + 1, y))
                    { 
                    MoveRight();
                    }
                    break;
                default:
                    Update(map, enemy);
                    break;
            }
        }
    }
}
