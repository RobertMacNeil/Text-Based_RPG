using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    abstract class GameCharacter
    {
        // stats
        string name;
        int health;
        int maxHealth;
        int shield;
        int maxShield;
        int lives;

        public void ShowStats()
        {
            Console.WriteLine(name + "'s stats:");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
        }

        public void TakeDamage(int damage)
        {

        }

        public void Heal(int heal)
        {
            //debug
            Console.WriteLine(name + " is about to heal " + heal + " health.");
            if(heal < 0)
            {
                heal = 0;
                //debug
                Console.WriteLine("ERROR: Must be a positve value");
                return;
            }
            health = health + heal;
        }

        public void RegenerateShield(int regen)
        {

        }
    }
}
