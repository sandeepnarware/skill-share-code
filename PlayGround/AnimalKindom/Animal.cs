using System;

namespace AnimalKindom
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Color { get; set; }

        public abstract void Sound();

        public void Sleep()
        {
            // Code to implement Sleep   
        }

        public void Walk()
        {
            // Code implement Walk
        }

        public void Stand()
        {
            // Code to implement Stand
        }
    }
}
