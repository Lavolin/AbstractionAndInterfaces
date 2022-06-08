using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Fish : Animal
    {
        public Fish() : base(FoodType.Grass, 5) { }
        public void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
