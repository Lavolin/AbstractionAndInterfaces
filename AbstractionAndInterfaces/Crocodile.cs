using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Crocodile : Animal
    {
        public Crocodile() : base(FoodType.Meat, 15) { }

        public override void Eat()
        {
            Console.WriteLine("Eating ALL");
        }
        public void ScarePeople()
        {
            Console.WriteLine("Boo");
        }
    }
}
