using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    public class Cow : Animal
    {
        public int MilkPerDay { get; set; }

        public override void Sound()
        {
            Console.Beep(500, 500);
        }
    }
}
