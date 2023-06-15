using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance
{
    internal class Game_Object
    {
        public Position Position { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Drawing at {Position.X}:{Position.Y}");
        }
    }
}
