using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5,

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScary = true,
                Habitat = "swamp",
                CanGrowTail = true,
            };
        }
    }
}
