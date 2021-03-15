using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class Enemy : GameCharacter
    {
        Random rnd;
        public Enemy(int rndSeed)
        {
            avatar = 'E';
            maxHealth = 75;
            health = 75;
            maxSheild = 75;
            shield = 75;
            lives = 1;
            strength = 5;
            x = 95;
            y = 20;
            rnd = new Random(rndSeed);
        }

        public void Update(Map map, Player player)
        {
            int move = rnd.Next(1, 5);

            switch(move)
            {
                case 1:
                    if ((player.X == x) && (player.Y == y - 1))
                    {
                        player.TakeDamage(strength);
                    }
                    else if (map.MoveCheck(x, y - 1))
                    {
                        MoveUp();
                    }
                    break;
                case 2:
                    if ((player.X == x) && (player.Y == y + 1))
                    {
                        player.TakeDamage(strength);
                    }
                    else if (map.MoveCheck(x, y + 1))
                    {
                        MoveDown();
                    }
                    break;
                case 3:
                    if ((player.X == x - 1) && (player.Y == y))
                    {
                        player.TakeDamage(strength);
                    }
                    else if (map.MoveCheck(x - 1, y))
                    {
                        MoveLeft();
                    }
                    break;
                case 4:
                    if ((player.X == x + 1) && (player.Y == y))
                    {
                        player.TakeDamage(strength);
                    }
                    else if (map.MoveCheck(x + 1, y))
                    {
                        MoveRight();
                    }
                    break;
                default:
                    Update(map, player);
                break;
            }
        }
    }
}
