using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    // inherits gamecharacter
    class Enemy : GameCharacter
    {
        Random rnd = new Random();
        int moveDirection;

        public Enemy()
        {
            //constructor sets base variables
            name = "Enemy";
            token = 'E';
            maxHealth = 100;
            maxShield = 100;
            health = 100;
            shield = 100;
            lives = 1;
            x = 26;
            y = 13;
        }

        public void Update(Map currentMap, Player player)
        {
            if (alive == false) return;

            moveDirection = rnd.Next(1, 5);
            switch (moveDirection)
            {
                case 1:
                    if ((player.x == x) && (player.y == y - 1) && player.Alive)
                    {
                        player.TakeDamage(5);
                    }
                    else if (currentMap.MoveCheck(x, y - 1))
                    {
                        MoveUp();
                    }
                    else Update(currentMap, player);
                    break;
                case 2:
                    if ((player.x == x) && (player.y == y + 1) && player.Alive)
                    {
                        player.TakeDamage(5);
                    }
                    else if (currentMap.MoveCheck(x, y + 1))
                    {
                        MoveDown();
                    }
                    else Update(currentMap, player);
                    break;
                case 3:
                    if ((player.x == x - 1) && (player.y == y) && player.Alive)
                    {
                        player.TakeDamage(5);
                    }
                    else if (currentMap.MoveCheck(x - 1, y))
                    {
                        MoveLeft();
                    }
                    else Update(currentMap, player);
                    break;
                case 4:
                    if ((player.x == x + 1) && (player.y == y) && player.Alive)
                    {
                        player.TakeDamage(5);
                    }
                    else if (currentMap.MoveCheck(x + 1, y))
                    {
                        MoveRight();
                    }
                    else Update(currentMap, player);
                    break;
                default:
                    Update(currentMap, player);
                    break;
            }
        }
    }
}
