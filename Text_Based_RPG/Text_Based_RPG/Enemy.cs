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

        private Player player;
        private Map currentMap;
        public Enemy(Map CurrentMap)
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
            currentMap = CurrentMap;
        }

        public void PlayerReference(Player player)
        {
            player = this.player;
        }

        public void Update()
        {
            moveDirection = rnd.Next(1, 5);
            switch (moveDirection)
            {
                case 1:
                    if (currentMap.MoveCheck(x, y - 1))
                    {
                        MoveUp();
                    }
                    else Update();
                    break;
                case 2:
                    if (currentMap.MoveCheck(x, y + 1))
                    {
                        MoveDown();
                    }
                    else Update();
                    break;
                case 3:
                    if (currentMap.MoveCheck(x - 1, y))
                    {
                        MoveLeft();
                    }
                    else Update();
                    break;
                case 4:
                    if (currentMap.MoveCheck(x + 1, y))
                    {
                        MoveRight();
                    }
                    else Update();
                    break;
                default:
                    Update();
                    break;
            }
        }
    }
}
