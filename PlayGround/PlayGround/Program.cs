using AnimalKindom;
using LearningAbstractClass;
using PlayGround;
using System;
using System.Collections.Generic;

namespace PlayGround
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal Kamdhenu = new Cow()
            {
                Color = "white",
                Height = 4,
                Weight = 200,
            };

            Kamdhenu.Sound();

            Animal Browny = new Cat()
            {
                Color = "Brown",
                Height = 1,
                Weight = 20,
            };

            Browny.Sound();

            Animal Tiger = new Dog()
            {
                Color = "Black",
                Height = 3,
                Weight = 45,
            };

            Tiger.Sound();
        }
    }
}