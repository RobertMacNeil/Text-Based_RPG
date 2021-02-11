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
            y = 2;
        }
    }
}
