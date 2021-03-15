using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    abstract class GameCharacter : GameObject
    {
        protected int maxHealth;
        protected int health;
        protected int maxSheild;
        protected int shield;
        protected int lives;

        public int Lives
        {
            get => lives;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(avatar);
        }

        public void TakeDamage(int damage)
        {
            if(damage <= 0)
            {
                Console.WriteLine("too weak to inflict damage");
                damage = 0;
            }

            shield = shield - damage;

            if(shield <= 0)
            {
                int overflow = shield * -1;
                shield = 0;
                health = health - overflow;
            }

            if(health <= 0)
            {
                lives = lives - 1;
            }

        }

        //movement
        public void MoveUp()
        {
            y = y - 1;
        }
        public void MoveDown()
        {
            y = y + 1;
        }
        public void MoveLeft()
        {
            x = x - 1;
        }
        public void MoveRight()
        {
            x = x + 1;
        }

    }
}
