using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class Player : GameCharacter
    {
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
        }

        public void Update()
        {

        }
    }
}
