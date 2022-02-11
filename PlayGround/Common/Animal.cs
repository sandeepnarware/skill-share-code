using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public int NumberOfLegs { get; set; }
        public string ColorOfBody { get; set; }

        public Animal()
        {
            Console.WriteLine("Animal Constructure is called");
        }

        public void Breath()
        {
            // other code
            Console.WriteLine("Animal is breathing");
        }

        public abstract void Run();
    }
}
