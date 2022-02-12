using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    public class Dog : Animal
    {
        public string BarkType { get; set; }

        public override void Sound()
        {
            Console.Beep(1200, 1200);
        }
    }
}
