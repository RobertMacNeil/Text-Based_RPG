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
        public Enemy()
        {
            //constructor sets base variables
            name = "Enemy";
            token = 'E';
            maxHealth = 100;
            maxShield = 100;
            health = 100;
            shield = 100;
            lives = 3;
            x = 20;
            y = 10;
        }
    }
}
