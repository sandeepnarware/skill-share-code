using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Squer : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drow Squer with default values");
        }

        public override void Draw(int dimention)
        {
            Console.WriteLine($"Drow Squer with {dimention}");
        }
    }
}
