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
        }

        public void TakeDamage(int damage)
        {
            //debug
            Console.WriteLine(name + " is about to take " + damage + " damage.");
            if (damage < 0)
            {
                damage = 0;
                //debug
                Console.WriteLine("ERROR: Must be a positive value");
                return;
            }
            shield = shield - damage;
            if (shield < 0)
            {
                Console.WriteLine(name + " took " + damage + " damage.");
                Console.WriteLine(name + "'s shield is broken!");
                damage = shield * -1;
                shield = 0;
                health = health - damage;
                Console.WriteLine(name + " lost " + damage + " health.");

                if (health <= 0)
                {
                    lives = lives - 1;
                    health = 0;
                    ////////////////////// left off here
                }
            }
        }

        public void Heal(int heal)
        {
            //debug
            Console.WriteLine(name + " is about to heal " + heal + " health.");
            if(heal < 0)
            {
                heal = 0;
                //debug
                Console.WriteLine("ERROR: Must be a positive value");
                return;
            }
            health = health + heal;
            if(health > maxHealth)
            {
                health = maxHealth;
                Console.WriteLine(name + " has been brought to full health");
            }
        }

        public void RegenerateShield(int regen)
        {
            //debug
            Console.WriteLine(name + " is about to regenerate " + regen + " shield.");
            if (regen < 0)
            {
                regen = 0;
                //debug
                Console.WriteLine("ERROR: Must be a positive value");
                return;
            }
            shield = shield + regen;
            if (shield > maxShield)
            {
                shield = maxShield;
                Console.WriteLine(name + " has regenerated full shielding");
            }
        }
    }
}
