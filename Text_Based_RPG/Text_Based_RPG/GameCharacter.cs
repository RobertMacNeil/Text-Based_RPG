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
        protected bool alive = true;
        protected string name;
        protected char token;
        protected int health;
        protected int maxHealth;
        protected int shield;
        protected int maxShield;
        protected int lives;
        public int x;
        public int y;

        public bool Alive
        {
            get => alive;
        }

        public void ShowStats()
        {
            Console.WriteLine(name + "'s stats:");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
        }

        //main combat call
        public void TakeDamage(int damage)
        {
            //debug
            Console.WriteLine(name + " is about to take " + damage + " damage.");
            //checks if in range
            if (damage < 0)
            {
                damage = 0;
                //debug
                Console.WriteLine("ERROR: Must be a positive value");
                return;
            }
            //deals damage
            shield = shield - damage;
            //checks if excess damage remains
            if (shield < 0)
            {
                Console.WriteLine(name + " took " + damage + " damage.");
                Console.WriteLine(name + "'s shield is broken!");
                //calculates excess damage
                damage = shield * -1;
                //sets shield to broken(0)
                shield = 0;
                //deals damage to health
                health = health - damage;
                Console.WriteLine(name + " lost " + damage + " health.");
                //checks for death
                if (health <= 0)
                {
                    lives = lives - 1;
                    health = 0;
                    //checks if final life loss
                    if (lives == 0)
                    {
                        Console.WriteLine(name + " has died");
                        token = 'X';
                        alive = false;
                    }
                    //if still has lives reset)
                    else
                    {
                        Console.WriteLine(name + " has " + lives + " extra lives left");
                        health = maxHealth;
                        shield = maxShield;
                    }
                }
            }
        }

        //recovers health //will probably have an item to use this
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

        //repairs shield //will probably have an item to use this
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

        //place characters onto the screen
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(token);
        }

        //Movement
        protected void MoveUp()
        {
            y = y - 1;
        }
        protected void MoveDown()
        {
            y = y + 1;
        }
        protected void MoveLeft()
        {
            x = x - 1;
        }
        protected void MoveRight()
        {
            x = x + 1;
        }

    }
}
