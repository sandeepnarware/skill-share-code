using System;

namespace Polymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drow shape with default values");
        }

        public virtual void Draw(int dimention)
        {
            Console.WriteLine($"Drow shape with {dimention}");
        }
    }
}
