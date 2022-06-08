using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces.Contracts
{
    public interface IFeedable
    {
        void Eat();

        public FoodType FoodType { get; set; }

        public int Doze { get; set; }
    }
}
