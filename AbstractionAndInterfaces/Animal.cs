using AbstractionAndInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Animal : IFeedable
    {
        public Animal(FoodType foodType, int doze)
        {
            FoodType = foodType;
            Doze = doze;
        }

        public FoodType FoodType { get; set; }

        public int Doze { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("I am eating");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping");
        }

        public void Play()
        {
            Console.WriteLine("I am playing");
        }
    }
}
