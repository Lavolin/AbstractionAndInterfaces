using AbstractionAndInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Baby : IFeedable
    {
        public FoodType FoodType { get ; set; }
        public int Doze { get ; set; }

        public void Eat()
        {
            Console.WriteLine("Whaa, whaa");
        }
    }
}
