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

        public void moveUp()
        {
            y = y - 1;
        }
        public void moveDown()
        {
            y = y + 1;
        }
        public void moveLeft()
        {
            x = x - 1;
        }
        public void moveRight()
        {
            x = x + 1;
        }


    }
}
