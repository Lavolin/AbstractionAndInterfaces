﻿using AbstractionAndInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Lion : IFeedable
    {
        public FoodType FoodType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Doze { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Eat()
        {

        }
    }
}
