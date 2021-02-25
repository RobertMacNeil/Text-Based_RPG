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
        private Enemy enemy;
        private Map currentMap;
        public Player(Map CurrentMap)
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
            currentMap = CurrentMap;
        }

        public void EnemyReference(Enemy enemy)
        {
            enemy = this.enemy;
        }

        public void Update()
        {
            ConsoleKeyInfo pressed = Console.ReadKey(true);
            ConsoleKey input = pressed.Key;
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    if (currentMap.MoveCheck(x,y-1))
                    {
                        MoveUp();
                    }
                    break;
                case ConsoleKey.W:
                    if (currentMap.MoveCheck(x, y - 1))
                    {
                        MoveUp();
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (currentMap.MoveCheck(x, y + 1))
                    {
                        MoveDown();
                    }
                    break;
                case ConsoleKey.S:
                    if (currentMap.MoveCheck(x, y + 1))
                    {
                        MoveDown();
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (currentMap.MoveCheck(x - 1, y))
                    {
                        MoveLeft();
                    }
                    break;
                case ConsoleKey.A:
                    if (currentMap.MoveCheck(x - 1, y))
                    {
                        MoveLeft();
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (currentMap.MoveCheck(x + 1, y))
                    {
                        MoveRight();
                    }
                    break;
                case ConsoleKey.D:
                    if (currentMap.MoveCheck(x + 1, y))
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
