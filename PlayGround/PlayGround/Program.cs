using Common;
using PlayGround;
using System;

namespace PlayGround
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            Car c = new Car();
            Console.WriteLine(d is Animal);
            Console.WriteLine(c is Animal);

        }
    }
}