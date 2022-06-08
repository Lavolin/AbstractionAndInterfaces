using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Printer
    {
        public int Color { get; set; }

        public int Size { get; set; }

        public void Cleaning()
        {
            Console.WriteLine("Cleaning");
        }
        public abstract void Print();
       
    }
}
