using System;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer a3dPrinter  = new a3DPrinter();
            Printer paperPrinter  = new PaperPrinter();

            paperPrinter.Print();
        }
    }
}
