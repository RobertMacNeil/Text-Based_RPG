using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    abstract class GameObject
    {
        protected string name;
        protected char token;
        public int x;
        public int y;

        //place characters onto the screen
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(token);
        }
    }
}
